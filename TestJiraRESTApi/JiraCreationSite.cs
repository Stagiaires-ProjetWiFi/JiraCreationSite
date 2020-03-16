using System;
using System.Windows.Forms;
using Jira.SDK.Domain;
using Jira.SDK;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using RestSharp;

namespace JiraCreationSite
{
    public partial class JiraCreationSite : Form
    {
        #region Constantes

        /// <summary>
        /// URL du JIRA (Tous les projets sont inclus, pas juste ProjetWiFi)
        /// ATTENTION: Cette constante est aussi définie dans Login.cs
        /// </summary>
        const string URL = "https://jira.montreal.ca";

        /// <summary>
        /// ID que Jira donne au projet Wifi corporatif.
        /// </summary>
        const string PROJECT_ID = "WCV";

        /// <summary>
        /// Id des tâche et sous-tâches
        /// </summary>
        enum IssueTypes { Task = 10005, Subtask = 10006 };
        /// <summary>
        /// Liste des responsables de sites
        /// </summary>
        public List<Assignee> ASSIGNEES = new List<Assignee>(){
            new Assignee() { Name = "Aucun", CodeU = ""},
            new Assignee() { Name = "Constantin", CodeU = "upatrco"},
            new Assignee() { Name = "Jerry", CodeU = "usitaul"}
        };
        /// <summary>
        /// Liste des rapporteurs de sites
        /// </summary>
        public List<Assignee> REPORTERS = new List<Assignee>(){
            new Assignee() { Name = "Viktoriya", CodeU = "ulefivi"},
            new Assignee() { Name = "Ghada", CodeU = "umohagh"}
        };
        /// <summary>
        /// Key de la issue qu'on utilise comme template.
        /// </summary>
        public string TEMPLATE_ISSUE = "WCV-10811";
        /// <summary>
        /// Liste des Sous-Tâches du site
        /// </summary>
        public List<string> PROCEDURES = new List<string>()
        {
            "Visite",
            "Plan de couverture",
            "Rapport-PID",
            "Plan d'emplacement des AP",
            "Approbation du Gestionnaire Immobilier",
            "Aménagement de la Salle Telecom",
            "Demande de VLAN (Bell)",
            "Augmentation du lien (Bell)",
            "Retrait du service Zap",
            "Câblage et installation des AP",
            "Préparation des AP",
            "Livraison des AP",
            "Mise en réseau des AP",
            "Configuration des commutateurs",
            "Installation des commutateurs",
            "Mise à jour de What's UP",
            "Dossier Cisco Prime",
            "Exit Site Survey",
            "Transfert aux opérations"
        };
        #endregion

        #region Variables
        /// <summary>
        /// Username de l'utilisateur. Toutes les actions faites par le programmes vont êtres faites à son nom.
        /// </summary>
        public string Code_U { get;}

        /// <summary>
        /// Mot de passe Jira. Vous devez reset le mot de passe sur Jira (envoyer un courriel de réinitialisation). Le mot de passe n'est pas le même que Google.
        /// </summary>
        public string Password { get;}
        /// <summary>
        /// Instance le l'objet contenant la connection à Jira. Vous devez appeler Jira.Connect(URL,CODE_U,PASSWORD); pour utiliser ses fonctions.
        /// </summary>
        public Jira.SDK.Jira InstanceJira { get; set; }
        /// <summary>
        /// Tous les labels déja existants sur Jira.
        /// </summary>
        public List<string> Labels { get; set; }
        /// <summary>
        /// Tous les composantes déja existants sur Jira.
        /// </summary>
        public List<string> Components { get; set; }
        /// <summary>
        /// Tous les fix versions déja existants sur Jira.
        /// </summary>
        public List<string> FixVersions { get; set; }
        /// <summary>
        /// Instance du projet WiFiMTL
        /// </summary>
        public Project Project { get; set; }
        /// <summary>
        /// Liste des status du site.
        /// </summary>
        public List<Status> Status { get; set; }
        #endregion

        #region Méthodes
        /// <summary>
        /// Fonction de départ du programme. Elle appelle toutes les autres fonctions.
        /// </summary>
        public JiraCreationSite(string username, string password)
        {
            Code_U = username;
            Password = password;
            InitializeComponent();
            InitializeJira();
        }

        /// <summary>
        /// Instancie la Variable Jira et connecte l'utilisateur indiqué dans les Constantes (CODE_U,PASSWORD)
        /// </summary>
        private void InitializeJira()
        {
            InstanceJira = new Jira.SDK.Jira();
            InstanceJira.Connect(URL, Code_U, Password);
            Project = InstanceJira.GetProject(PROJECT_ID);
            LoadJiraValues(Project);
        }

        /// <summary>
        /// Load les labels à partir de l'API
        /// </summary>
        /// <returns>Une liste de tous les labels du Jira</returns>
        public SuggestionListStruct LoadLabelsJSON()
        {
            ///Fait une requête Http à Jira pour obtenir les labels (Jira retourne du JSON)
            var request = WebRequest.Create("https://jira.montreal.ca/rest/api/1.0/labels/suggest?query=");
            String encoded = Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Code_U + ":" + Password));
            request.Headers.Add("Authorization", "Basic " + encoded);
            var response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string json = streamReader.ReadToEnd();
            streamReader.Close();
            stream.Close();
            response.Close();

            //Deserialize le JSON vers un object C#
            return JsonConvert.DeserializeObject<SuggestionListStruct>(json);
        }

        /// <summary>
        /// Load les informations de Jira dans l'interface d'utilisateur. (Composantes existantes, labels existants, etc...)
        /// </summary>
        /// <param name="project"></param>
        private void LoadJiraValues(Project project)
        {
            //Components
            Components = project.Components.OrderBy(c => c.Name).Select(c => c.Name).ToList();
            CB_Components.Items.AddRange(Components.ToArray());
            //Fix Versions
            FixVersions = project.ProjectVersions.OrderBy(c => c.Name).Select(v => v.Name).ToList();
            CB_FixVersions.Items.AddRange(FixVersions.ToArray());

            //Labels
            Labels = LoadLabelsJSON().Suggestions.OrderBy(c => c.Label).Select(s => s.Label).ToList();
            CB_Labels.Items.AddRange(Labels.ToArray());

            //Status
            Status = InstanceJira.GetIssue(TEMPLATE_ISSUE).GetTransitions().Select(t => new Status() { Id = t.ID, Name = t.Name }).ToList();
            CB_Status.DataSource = Status.Select(s => s.Name).ToList();

            //Asignee (Responsable)
            CB_Asignee.DataSource = ASSIGNEES.Select(a => a.Name).ToList();

            //Reporter (Rapporteur)
            CB_Reporter.DataSource = REPORTERS.Select(a => a.Name).ToList();
        }

        /// <summary>
        /// Update la Issue spécifié en paramètre.
        /// </summary>
        /// <param name="issue">Issue à update. Les valeurs null vont être ignorés.</param>
        /// <returns></returns>
        public Issue UpdateIssue(Issue issue)
        {
            try
            {
                //Obtiens toutes les informations pour la requêtte HTTP (où envoyer le data)
                var request = new RestRequest(String.Format("{0}/issue/{1}", "/rest/api/latest", issue.Key), Method.PUT)
                {
                    RequestFormat = DataFormat.Json
                };
                request.AddHeader("ContentType", "application/json");

                //Vérifie les champs vides et les insère dans updateData.
                //Pour ajouter des paramètres simplement vérifier les termes que Jira s'attend à recevoir. 
                //Doccumentation sur les issues: https://docs.atlassian.com/software/jira/docs/api/REST/7.11.0/?_ga=2.22529979.1664138459.1580918498-930784463.1580918498#api/2/issue
                var updateData = new Dictionary<string, object>();
                if (issue.Summary != null)
                    updateData.Add("summary", new[] { new { set = issue.Summary } });
                if (issue.Description != null)
                    updateData.Add("description", new[] { new { set = issue.Description } });
                if (issue.Labels != null)
                    updateData.Add("labels", new[] { new { set = issue.Labels } });
                if (issue.Fields.Components != null)
                    updateData.Add("components", new[] { new { set = issue.Fields.Components.Select(c => new { field = "id", c.ID }) } });

                //Ajoute updateData au body de la requête.
                request.AddBody(new { update = updateData });

                //Créer une instance de RestClient (Library qui compile et envoie des requêtes HTTP)
                var restClient = new RestSharp.RestClient(URL)
                {
                    Authenticator = new RestSharp.Authenticators.HttpBasicAuthenticator(Code_U, Password)
                };

                //Exécution de la requête
                var response = restClient.Execute(request);

                //On gère les erreurs HTTP et affiche pourquoi la requête n'a pas fonctionné.
                if (response.ErrorException != null)
                    throw new HttpException((int)response.StatusCode, "Transport level error: " + response.ErrorMessage, response.ErrorException);
                if (response.StatusCode != System.Net.HttpStatusCode.NoContent)
                    throw new HttpException((int)response.StatusCode, "JIRA returned wrong status: " + response.StatusDescription + "Content: " + response.Content);

                return InstanceJira.GetIssue(issue.Key);
            }
            catch (Exception ex)
            {
                //Erreurs de logique de la méthode.
                System.Diagnostics.Trace.TraceError("UpdateIssue(issue) error: {0}", ex);
                throw new HttpException("Could not update issue", ex);
            }
        }

        /// <summary>
        /// Valide les champs du formulaire.
        /// </summary>
        /// <returns>Retourne un string vide si les champs sont valide. Sinon, retourne les messages d'erreurs</returns>
        private List<string> FieldsAreValid()
        {
            //Variable de retour
            var rtn = new List<string>();

            /*ID*/ if (NUD_ID.Value <= 0) rtn.Add("ERREUR VALIDATION: L'ID du Site ne peut pas être 0!");

            /*Adress*/ if (string.IsNullOrWhiteSpace(TB_Adress.Text)) rtn.Add("ERREUR VALIDATION: Veuillez entrer une adresse!");

            //***Ajouter les validations avant cette ligne***
            /*Fin validation*/ return rtn;
        }
        /// <summary>
        /// Lit toutes les informations du formulaire et les insère dans un objet
        /// </summary>
        /// <returns>RequestBody: Objet contenant toutes les informations du formulaire</returns>
        private RequestBody CreateRequestBody()
        {
            //Formatting
            var idSite = NUD_ID.Value.ToString().PadLeft(4, '0');
            var nomSite = $"#{idSite} | {TB_Adress.Text}";
            if (!string.IsNullOrWhiteSpace(TB_Occupation.Text)) nomSite += $" ({TB_Occupation.Text})";
            if (!string.IsNullOrWhiteSpace(TB_MoreInfos.Text)) nomSite += $" - {TB_MoreInfos.Text}";

            var requestBody = new RequestBody()
            {
                fields = new RequestBody.Fields()
                {
                    project = new RequestBody.Project() { key = PROJECT_ID },
                    summary = nomSite,
                    description = nomSite,
                    reporter = new RequestBody.Reporter() { name = REPORTERS.Single(r => r.Name == CB_Reporter.Text).CodeU },
                    assignee = new RequestBody.Assignee() { name = ASSIGNEES.Single(a => a.Name == CB_Asignee.Text).CodeU },
                    issuetype = new RequestBody.Issuetype() { id = ((int)IssueTypes.Task).ToString() },
                }
            };
            if (DGV_Components.Rows.Count > 0)
            {
                requestBody.fields.components = new List<RequestBody.Component>();
                foreach (DataGridViewRow row in DGV_Components.Rows)
                {
                    var cell = row.Cells[0];
                    if (!string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        requestBody.fields.components.Add(new RequestBody.Component() { name = cell.Value.ToString() });
                }
            }
            if (DGV_Labels.Rows.Count > 0)
            {
                requestBody.fields.labels = new List<string>();
                foreach (DataGridViewRow row in DGV_Labels.Rows)
                {
                    var cell = row.Cells[0];
                    if (!string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        requestBody.fields.labels.Add(cell.Value.ToString());
                }
            }
            if (DGV_FixVersions.Rows.Count > 0)
            {
                requestBody.fields.fixVersions = new List<RequestBody.FixVersions>();
                foreach(DataGridViewRow row in DGV_FixVersions.Rows)
                {
                    var cell = row.Cells[0];
                    if (!string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        requestBody.fields.fixVersions.Add(new RequestBody.FixVersions() { name = cell.Value.ToString() });
                }
            }
            return requestBody;
        }
        #endregion

        #region Évenements
        /// <summary>
        /// Événement quand on appuie sur le bouton Créer le site.
        /// </summary>
        /// <param name="sender">Object qui appel la fonction (bouton GO).</param>
        /// <param name="e">Arguments passé par l'objet.</param>
        private void BTN_GO_Click(object sender, EventArgs e)
        {
            //Validation
            var validationErrors = FieldsAreValid();
            if (validationErrors.Count == 0)
            {
                //Bloque les intéractions
                RTB_Log.AppendText("\r\nExécution du script en cours, veuillez patienter!"); RTB_Log.ScrollToCaret();
                Cursor = Cursors.WaitCursor;
                TLP_Main.Enabled = false;

                //Actions
                var key = CreateSite();

                //Réactive les intéractions
                RTB_Log.AppendText("\r\nExécution Complête: Le site à été correctement crée! https://jira.montreal.ca/browse/" + key); RTB_Log.ScrollToCaret();
                TLP_Main.Enabled = true;
                Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Erreur de validation, Veuillez réessayer!\n\n Les champs incorrects sont visibles dans la boite de messages au bas de la fenêtre.", "Erreur de validation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (var error in validationErrors)
                RTB_Log.AppendText("\r\n" + error); RTB_Log.ScrollToCaret();
            }
        }
        private void DGV_KeyDown(object sender, KeyEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewCell cell in dgv.SelectedCells)
                {
                    dgv.Rows.RemoveAt(cell.RowIndex);
                }
            }
        }
        private void CB_Components_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CB_Components.Text)) return;
            DGV_Components.Rows.Add(CB_Components.SelectedItem.ToString());
        }
        private void CB_Components_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CB_Components.Text)) return;
            if (e.KeyCode == Keys.Enter && !Components.Contains(CB_Components.Text))
            {
                MessageBox.Show("Composante inexistante, Veuillez réessayer!\n\n  Pour ajouter des nouvelles composantes communiquez avec un administrateur du projet Jira.", "Composante inexistante!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CB_Components.ResetText();
            }
        }
        private void CB_FixVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CB_FixVersions.Text)) return;
            DGV_FixVersions.Rows.Add(CB_FixVersions.SelectedItem.ToString());
        }
        private void CB_FixVersions_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CB_FixVersions.Text)) return;
            if (e.KeyCode == Keys.Enter && !FixVersions.Contains(CB_FixVersions.Text))
            {
                MessageBox.Show("Version corrigée inexistante, Veuillez réessayer!\n\n  Pour ajouter des nouvelles versions corrigées communiquez avec un administrateur du projet Jira.", "Version corrigée inexistante!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CB_Components.ResetText();
            }
        }
        private void CB_Labels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CB_Labels.Text)) return;
            DGV_Labels.Rows.Add(CB_Labels.SelectedItem.ToString());
        }
        private void CB_Labels_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CB_Labels.Text)) return;
            if (e.KeyCode == Keys.Enter && !CB_Labels.Items.Contains(CB_Labels.Text))
            {
                DGV_Labels.Rows.Add(CB_Labels.Text);
                CB_Labels.ResetText();
            }
        }
        private void RTB_Log_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
        private void JiraCreationSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Requete vers Jira
        /// <summary>
        /// Appel HTML qui va envoyer/modifier du contenu sur Jira (POST, UPDATE, DELETE)
        /// </summary>
        private string CreateSite()
        {
            //Création de l'objet pour le body de la requete
            var requestBody = CreateRequestBody();

            //Tâche principale
            var newSiteKey = CreateIssue(requestBody).Key;
            RTB_Log.AppendText("\r\nEXÉCUTION: Tâche Principale crée."); RTB_Log.ScrollToCaret();

            //Sous-Tâches
            requestBody.fields.issuetype = new RequestBody.Issuetype() { id = ((int)IssueTypes.Subtask).ToString() };
            requestBody.fields.assignee.name = string.Empty;
            requestBody.fields.parent = new RequestBody.Parent() { key = newSiteKey };
            foreach (var procedure in PROCEDURES)
            {
                requestBody.fields.summary = procedure;
                CreateIssue(requestBody);
                RTB_Log.AppendText($"\r\nEXÉCUTION: Sous-tâche: \"{procedure}\" crée."); RTB_Log.ScrollToCaret();
            }
            return newSiteKey;
        }

        /// <summary>
        /// Envoie la requêtte http à Jira.
        /// </summary>
        /// <param name="requestBody">RequestBody: Objet contenant toutes les informations du formulaire</param>
        /// <returns>Retourne la Issue Crée</returns>
        private Issue CreateIssue(RequestBody requestBody)
        {
            try
            {
                //Obtiens toutes les informations pour la requêtte HTTP (où envoyer le data)
                var request = new RestRequest("/rest/api/2/issue/", Method.POST);
                request.AddHeader("ContentType", "application/json");

                var json = JsonConvert.SerializeObject(requestBody, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                //Ajoute issueData au body de la requête.
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                //Créer une instance de RestClient (Library qui compile et envoie des requêtes HTTP)
                var restClient = new RestClient(URL)
                {
                    Authenticator = new RestSharp.Authenticators.HttpBasicAuthenticator(Code_U, Password)
                };

                //Exécution de la requête
                var response = restClient.Execute(request);

                //On gère les erreurs HTTP et affiche pourquoi la requête n'a pas fonctionné.
                if (response.ErrorException != null)
                    throw new HttpException((int)response.StatusCode, "Erreur HTTP: " + response.ErrorMessage, response.ErrorException);
                if (response.StatusCode != HttpStatusCode.Created)
                    throw new HttpException((int)response.StatusCode, $"JIRA à retourné le mauvais status: {response.StatusCode} ({response.StatusDescription}){Environment.NewLine}Content: {response.Content}", response.ErrorException);

                var issueRef = JsonConvert.DeserializeObject<Issue>(response.Content);
                if (CB_Status.Text != Status.Single(s => s.Id == 61).Name && CB_Status.Text != "Backlog")
                    new JiraClient(URL,Code_U,Password).TransitionIssue(issueRef, new Transition() { ID = Status.Single(s => s.Name == CB_Status.Text).Id }, new Comment(""));
                return issueRef;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur durant la création du script: " + ex.Message);
            }
            return null;
        }
        #endregion

        
    }
}
