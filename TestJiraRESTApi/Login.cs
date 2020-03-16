using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using RestSharp;

namespace JiraCreationSite
{
    public partial class Login : Form
    {
        /// <summary>
        /// URL du JIRA (Tous les projets sont inclus, pas juste ProjetWiFi)
        /// ATTENTION: Cette constante est aussi définie dans JiraCreationSite.cs
        /// </summary>
        const string URL = "https://jira.montreal.ca";

        public Login()
        {
            InitializeComponent();
        }

        private void LKLBL_Admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jira.montreal.ca/secure/ContactAdministrators!default.jspa");
        }

        private void LKLBL_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jira.montreal.ca/secure/ForgotLoginDetails.jspa");
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            //Load...
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            //Reset les erreurs
            EP_LoginErrorMessage.Clear();

            //Si les champs sont ok
            if (ValidCredentials(TB_Username.Text, TB_Password.Text))
            {
                this.Hide();
                var jiraCreationSite = new JiraCreationSite(TB_Username.Text, TB_Password.Text);
                jiraCreationSite.ShowDialog();
            }
            else
            {
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }
            
        }

        private bool ValidCredentials(string username, string password)
        {
            //Verifie les champs vides
            var nullValues = false;
            if (string.IsNullOrWhiteSpace(TB_Username.Text))
            {
                EP_LoginErrorMessage.SetError(TB_Username, "Veuillez entrer une valeur.");
                nullValues = true;
            }
            if (string.IsNullOrWhiteSpace(TB_Password.Text))
            {
                EP_LoginErrorMessage.SetError(TB_Password, "Veuillez entrer une valeur.");
                nullValues = true;
            }
            if (nullValues) return false;

            //Requête simple pour savoir si les informations sont ok
            var request = new RestRequest("/rest/api/2/myself", Method.GET);
            var restClient = new RestClient(URL)
            {
                Authenticator = new RestSharp.Authenticators.HttpBasicAuthenticator(username, password)
            };
            var response = restClient.Execute(request);

            //On fait le check si la réponse n'est pas correcte
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string error;
                if (response.Headers.Any(h => (h.Value as string).Contains("CAPTCHA"))) 
                    error = "Vous avez lancé trops de connections incorrectes."+ Environment.NewLine + "Veuillez vous connecter directement sur https://jira.montreal.ca/login.jsp?nosso pour répondre au CAPTCHA nécessaire et";
                else
                    error = "Votre nom d'utilisateur et mot de passe sont incorrects.";

                MessageBox.Show("Désolé, "+ error + Environment.NewLine + "Veuillez recommencer.", "Connexion Jira", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EP_LoginErrorMessage.SetError(TB_Username, error);
                EP_LoginErrorMessage.SetError(TB_Password, error);
                return false;
            }

            //Réussite de toutes les validations
            return true;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.Enabled) BTN_Login_Click(sender, e);
        }
    }
}
