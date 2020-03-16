namespace JiraCreationSite
{
    partial class JiraCreationSite
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JiraCreationSite));
            this.GB_Components = new System.Windows.Forms.GroupBox();
            this.TLP_Components = new System.Windows.Forms.TableLayoutPanel();
            this.DGV_Components = new System.Windows.Forms.DataGridView();
            this.ComponentsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_Components = new System.Windows.Forms.ComboBox();
            this.GB_Labels = new System.Windows.Forms.GroupBox();
            this.TLP_Labels = new System.Windows.Forms.TableLayoutPanel();
            this.CB_Labels = new System.Windows.Forms.ComboBox();
            this.DGV_Labels = new System.Windows.Forms.DataGridView();
            this.LabelsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_Top = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Infos = new System.Windows.Forms.GroupBox();
            this.CB_Reporter = new System.Windows.Forms.ComboBox();
            this.LBL_Reporter = new System.Windows.Forms.Label();
            this.TB_MoreInfos = new System.Windows.Forms.TextBox();
            this.LBL_MoreInfos = new System.Windows.Forms.Label();
            this.LBL_Infos = new System.Windows.Forms.Label();
            this.CB_Asignee = new System.Windows.Forms.ComboBox();
            this.LBL_Assignee = new System.Windows.Forms.Label();
            this.LBL_Status = new System.Windows.Forms.Label();
            this.CB_Status = new System.Windows.Forms.ComboBox();
            this.TB_Occupation = new System.Windows.Forms.TextBox();
            this.LBL_Occupation = new System.Windows.Forms.Label();
            this.TB_Adress = new System.Windows.Forms.TextBox();
            this.NUD_ID = new System.Windows.Forms.NumericUpDown();
            this.LBL_Adresse = new System.Windows.Forms.Label();
            this.LBL_ID = new System.Windows.Forms.Label();
            this.TLP_Middle = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CB_FixVersions = new System.Windows.Forms.ComboBox();
            this.DGV_FixVersions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TLP_Bottom = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_GO = new System.Windows.Forms.Button();
            this.RTB_Log = new System.Windows.Forms.RichTextBox();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.GB_Components.SuspendLayout();
            this.TLP_Components.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Components)).BeginInit();
            this.GB_Labels.SuspendLayout();
            this.TLP_Labels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Labels)).BeginInit();
            this.TLP_Main.SuspendLayout();
            this.TLP_Top.SuspendLayout();
            this.GB_Infos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ID)).BeginInit();
            this.TLP_Middle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FixVersions)).BeginInit();
            this.TLP_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Components
            // 
            this.GB_Components.Controls.Add(this.TLP_Components);
            this.GB_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Components.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Components.Location = new System.Drawing.Point(3, 3);
            this.GB_Components.Name = "GB_Components";
            this.GB_Components.Size = new System.Drawing.Size(269, 198);
            this.GB_Components.TabIndex = 0;
            this.GB_Components.TabStop = false;
            this.GB_Components.Text = "Composantes";
            // 
            // TLP_Components
            // 
            this.TLP_Components.ColumnCount = 1;
            this.TLP_Components.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Components.Controls.Add(this.DGV_Components, 0, 1);
            this.TLP_Components.Controls.Add(this.CB_Components, 0, 0);
            this.TLP_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Components.Location = new System.Drawing.Point(3, 21);
            this.TLP_Components.Name = "TLP_Components";
            this.TLP_Components.RowCount = 2;
            this.TLP_Components.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLP_Components.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Components.Size = new System.Drawing.Size(263, 174);
            this.TLP_Components.TabIndex = 0;
            // 
            // DGV_Components
            // 
            this.DGV_Components.AllowDrop = true;
            this.DGV_Components.AllowUserToAddRows = false;
            this.DGV_Components.AllowUserToResizeColumns = false;
            this.DGV_Components.AllowUserToResizeRows = false;
            this.DGV_Components.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Components.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Components.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Components.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Components.ColumnHeadersVisible = false;
            this.DGV_Components.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentsCol});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Components.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Components.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_Components.Location = new System.Drawing.Point(3, 33);
            this.DGV_Components.Name = "DGV_Components";
            this.DGV_Components.RowHeadersVisible = false;
            this.DGV_Components.Size = new System.Drawing.Size(257, 168);
            this.DGV_Components.TabIndex = 1;
            this.DGV_Components.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV_KeyDown);
            // 
            // ComponentsCol
            // 
            this.ComponentsCol.HeaderText = "Components";
            this.ComponentsCol.Name = "ComponentsCol";
            // 
            // CB_Components
            // 
            this.CB_Components.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Components.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Components.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Components.FormattingEnabled = true;
            this.CB_Components.Location = new System.Drawing.Point(3, 3);
            this.CB_Components.Name = "CB_Components";
            this.CB_Components.Size = new System.Drawing.Size(257, 25);
            this.CB_Components.TabIndex = 0;
            this.ToolTips.SetToolTip(this.CB_Components, "Selection d\'une composante à être ajoutée à la liste. (Aucun ajout possible ici)");
            this.CB_Components.SelectedIndexChanged += new System.EventHandler(this.CB_Components_SelectedIndexChanged);
            this.CB_Components.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CB_Components_KeyDown);
            // 
            // GB_Labels
            // 
            this.GB_Labels.Controls.Add(this.TLP_Labels);
            this.GB_Labels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Labels.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Labels.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB_Labels.Location = new System.Drawing.Point(278, 3);
            this.GB_Labels.Name = "GB_Labels";
            this.GB_Labels.Size = new System.Drawing.Size(269, 198);
            this.GB_Labels.TabIndex = 1;
            this.GB_Labels.TabStop = false;
            this.GB_Labels.Text = "Étiquettes";
            // 
            // TLP_Labels
            // 
            this.TLP_Labels.ColumnCount = 1;
            this.TLP_Labels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Labels.Controls.Add(this.CB_Labels, 0, 0);
            this.TLP_Labels.Controls.Add(this.DGV_Labels, 0, 1);
            this.TLP_Labels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Labels.Location = new System.Drawing.Point(3, 21);
            this.TLP_Labels.Name = "TLP_Labels";
            this.TLP_Labels.RowCount = 2;
            this.TLP_Labels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLP_Labels.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Labels.Size = new System.Drawing.Size(263, 174);
            this.TLP_Labels.TabIndex = 1;
            // 
            // CB_Labels
            // 
            this.CB_Labels.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Labels.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Labels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Labels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Labels.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Labels.FormattingEnabled = true;
            this.CB_Labels.Location = new System.Drawing.Point(3, 3);
            this.CB_Labels.Name = "CB_Labels";
            this.CB_Labels.Size = new System.Drawing.Size(257, 25);
            this.CB_Labels.TabIndex = 0;
            this.ToolTips.SetToolTip(this.CB_Labels, "Selection d\'une étiquette à être ajoutée à la liste. (Ajout de nouvelle étiquette" +
        " possible)");
            this.CB_Labels.SelectedIndexChanged += new System.EventHandler(this.CB_Labels_SelectedIndexChanged);
            this.CB_Labels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CB_Labels_KeyDown);
            // 
            // DGV_Labels
            // 
            this.DGV_Labels.AllowDrop = true;
            this.DGV_Labels.AllowUserToAddRows = false;
            this.DGV_Labels.AllowUserToResizeColumns = false;
            this.DGV_Labels.AllowUserToResizeRows = false;
            this.DGV_Labels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Labels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Labels.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Labels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Labels.ColumnHeadersVisible = false;
            this.DGV_Labels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabelsCol});
            this.DGV_Labels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Labels.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_Labels.Location = new System.Drawing.Point(3, 33);
            this.DGV_Labels.Name = "DGV_Labels";
            this.DGV_Labels.RowHeadersVisible = false;
            this.DGV_Labels.Size = new System.Drawing.Size(257, 168);
            this.DGV_Labels.TabIndex = 1;
            this.DGV_Labels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV_KeyDown);
            // 
            // LabelsCol
            // 
            this.LabelsCol.HeaderText = "Labels";
            this.LabelsCol.Name = "LabelsCol";
            // 
            // TLP_Main
            // 
            this.TLP_Main.ColumnCount = 1;
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.Controls.Add(this.TLP_Top, 0, 0);
            this.TLP_Main.Controls.Add(this.TLP_Middle, 0, 1);
            this.TLP_Main.Controls.Add(this.TLP_Bottom, 0, 2);
            this.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Main.Location = new System.Drawing.Point(0, 0);
            this.TLP_Main.Name = "TLP_Main";
            this.TLP_Main.RowCount = 3;
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLP_Main.Size = new System.Drawing.Size(832, 501);
            this.TLP_Main.TabIndex = 0;
            // 
            // TLP_Top
            // 
            this.TLP_Top.ColumnCount = 1;
            this.TLP_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Top.Controls.Add(this.GB_Infos, 0, 0);
            this.TLP_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Top.Location = new System.Drawing.Point(3, 3);
            this.TLP_Top.Name = "TLP_Top";
            this.TLP_Top.RowCount = 1;
            this.TLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Top.Size = new System.Drawing.Size(826, 194);
            this.TLP_Top.TabIndex = 0;
            // 
            // GB_Infos
            // 
            this.GB_Infos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GB_Infos.Controls.Add(this.CB_Reporter);
            this.GB_Infos.Controls.Add(this.LBL_Reporter);
            this.GB_Infos.Controls.Add(this.TB_MoreInfos);
            this.GB_Infos.Controls.Add(this.LBL_MoreInfos);
            this.GB_Infos.Controls.Add(this.LBL_Infos);
            this.GB_Infos.Controls.Add(this.CB_Asignee);
            this.GB_Infos.Controls.Add(this.LBL_Assignee);
            this.GB_Infos.Controls.Add(this.LBL_Status);
            this.GB_Infos.Controls.Add(this.CB_Status);
            this.GB_Infos.Controls.Add(this.TB_Occupation);
            this.GB_Infos.Controls.Add(this.LBL_Occupation);
            this.GB_Infos.Controls.Add(this.TB_Adress);
            this.GB_Infos.Controls.Add(this.NUD_ID);
            this.GB_Infos.Controls.Add(this.LBL_Adresse);
            this.GB_Infos.Controls.Add(this.LBL_ID);
            this.GB_Infos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Infos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Infos.Location = new System.Drawing.Point(3, 3);
            this.GB_Infos.Name = "GB_Infos";
            this.GB_Infos.Size = new System.Drawing.Size(820, 188);
            this.GB_Infos.TabIndex = 0;
            this.GB_Infos.TabStop = false;
            this.GB_Infos.Text = "Informations principales";
            // 
            // CB_Reporter
            // 
            this.CB_Reporter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Reporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Reporter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CB_Reporter.FormattingEnabled = true;
            this.CB_Reporter.Location = new System.Drawing.Point(614, 41);
            this.CB_Reporter.Name = "CB_Reporter";
            this.CB_Reporter.Size = new System.Drawing.Size(200, 25);
            this.CB_Reporter.TabIndex = 13;
            this.ToolTips.SetToolTip(this.CB_Reporter, "Indiquation de qui sera le rapporteur de la Tâche et les Sous-Tâches");
            // 
            // LBL_Reporter
            // 
            this.LBL_Reporter.AutoSize = true;
            this.LBL_Reporter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LBL_Reporter.Location = new System.Drawing.Point(611, 21);
            this.LBL_Reporter.Name = "LBL_Reporter";
            this.LBL_Reporter.Size = new System.Drawing.Size(144, 17);
            this.LBL_Reporter.TabIndex = 12;
            this.LBL_Reporter.Text = "Rapporteur (Reporter)*";
            // 
            // TB_MoreInfos
            // 
            this.TB_MoreInfos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TB_MoreInfos.Location = new System.Drawing.Point(414, 137);
            this.TB_MoreInfos.Name = "TB_MoreInfos";
            this.TB_MoreInfos.Size = new System.Drawing.Size(400, 25);
            this.TB_MoreInfos.TabIndex = 9;
            this.ToolTips.SetToolTip(this.TB_MoreInfos, "Ce champs s\'ajoute après l\'occupation dans les Tâches et Sous-Tâches.");
            // 
            // LBL_MoreInfos
            // 
            this.LBL_MoreInfos.AutoSize = true;
            this.LBL_MoreInfos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LBL_MoreInfos.Location = new System.Drawing.Point(411, 117);
            this.LBL_MoreInfos.Name = "LBL_MoreInfos";
            this.LBL_MoreInfos.Size = new System.Drawing.Size(293, 17);
            this.LBL_MoreInfos.TabIndex = 8;
            this.LBL_MoreInfos.Text = "Autres informations (S\'ajoute au titre de la tâche)";
            // 
            // LBL_Infos
            // 
            this.LBL_Infos.AutoSize = true;
            this.LBL_Infos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Infos.Location = new System.Drawing.Point(6, 171);
            this.LBL_Infos.Name = "LBL_Infos";
            this.LBL_Infos.Size = new System.Drawing.Size(225, 13);
            this.LBL_Infos.TabIndex = 14;
            this.LBL_Infos.Text = "Les champs avec une étoile * sont obligatoires.";
            // 
            // CB_Asignee
            // 
            this.CB_Asignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Asignee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Asignee.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CB_Asignee.FormattingEnabled = true;
            this.CB_Asignee.Location = new System.Drawing.Point(408, 41);
            this.CB_Asignee.Name = "CB_Asignee";
            this.CB_Asignee.Size = new System.Drawing.Size(200, 25);
            this.CB_Asignee.TabIndex = 11;
            this.ToolTips.SetToolTip(this.CB_Asignee, "Indication de qui sera assigné a la Tâche principale.");
            // 
            // LBL_Assignee
            // 
            this.LBL_Assignee.AutoSize = true;
            this.LBL_Assignee.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LBL_Assignee.Location = new System.Drawing.Point(405, 21);
            this.LBL_Assignee.Name = "LBL_Assignee";
            this.LBL_Assignee.Size = new System.Drawing.Size(147, 17);
            this.LBL_Assignee.TabIndex = 10;
            this.LBL_Assignee.Text = "Responsable (Assignee)";
            // 
            // LBL_Status
            // 
            this.LBL_Status.AutoSize = true;
            this.LBL_Status.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LBL_Status.Location = new System.Drawing.Point(100, 20);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(48, 17);
            this.LBL_Status.TabIndex = 2;
            this.LBL_Status.Text = "Status*";
            // 
            // CB_Status
            // 
            this.CB_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Status.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CB_Status.FormattingEnabled = true;
            this.CB_Status.Location = new System.Drawing.Point(103, 40);
            this.CB_Status.Name = "CB_Status";
            this.CB_Status.Size = new System.Drawing.Size(199, 25);
            this.CB_Status.TabIndex = 3;
            this.ToolTips.SetToolTip(this.CB_Status, "Status du nouveau site.");
            // 
            // TB_Occupation
            // 
            this.TB_Occupation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TB_Occupation.Location = new System.Drawing.Point(8, 137);
            this.TB_Occupation.Name = "TB_Occupation";
            this.TB_Occupation.Size = new System.Drawing.Size(400, 25);
            this.TB_Occupation.TabIndex = 7;
            this.ToolTips.SetToolTip(this.TB_Occupation, "Ce champs s\'ajoute après l\'adresse dans les Tâches et Sous-Tâches. (Entre parenth" +
        "èses)");
            // 
            // LBL_Occupation
            // 
            this.LBL_Occupation.AutoSize = true;
            this.LBL_Occupation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LBL_Occupation.Location = new System.Drawing.Point(6, 117);
            this.LBL_Occupation.Name = "LBL_Occupation";
            this.LBL_Occupation.Size = new System.Drawing.Size(255, 17);
            this.LBL_Occupation.TabIndex = 6;
            this.LBL_Occupation.Text = "Occupation (Ex.: Bibliothèque, Aréna, etc...)";
            // 
            // TB_Adress
            // 
            this.TB_Adress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TB_Adress.Location = new System.Drawing.Point(8, 89);
            this.TB_Adress.Name = "TB_Adress";
            this.TB_Adress.Size = new System.Drawing.Size(806, 25);
            this.TB_Adress.TabIndex = 5;
            this.ToolTips.SetToolTip(this.TB_Adress, "Ce champs s\'ajoute au titre et à la description des Tâches et Sous-Tâches.");
            // 
            // NUD_ID
            // 
            this.NUD_ID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.NUD_ID.Location = new System.Drawing.Point(9, 41);
            this.NUD_ID.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUD_ID.Name = "NUD_ID";
            this.NUD_ID.Size = new System.Drawing.Size(75, 25);
            this.NUD_ID.TabIndex = 1;
            this.ToolTips.SetToolTip(this.NUD_ID, "Identification du site.");
            // 
            // LBL_Adresse
            // 
            this.LBL_Adresse.AutoSize = true;
            this.LBL_Adresse.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LBL_Adresse.Location = new System.Drawing.Point(6, 69);
            this.LBL_Adresse.Name = "LBL_Adresse";
            this.LBL_Adresse.Size = new System.Drawing.Size(277, 17);
            this.LBL_Adresse.TabIndex = 4;
            this.LBL_Adresse.Text = "Adresse (<adresse>, <ville>, <code postal>)*";
            // 
            // LBL_ID
            // 
            this.LBL_ID.AutoSize = true;
            this.LBL_ID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LBL_ID.Location = new System.Drawing.Point(6, 21);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(68, 17);
            this.LBL_ID.TabIndex = 0;
            this.LBL_ID.Text = "ID du site*";
            // 
            // TLP_Middle
            // 
            this.TLP_Middle.ColumnCount = 3;
            this.TLP_Middle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.TLP_Middle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.TLP_Middle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.TLP_Middle.Controls.Add(this.groupBox1, 2, 0);
            this.TLP_Middle.Controls.Add(this.GB_Components, 0, 0);
            this.TLP_Middle.Controls.Add(this.GB_Labels, 1, 0);
            this.TLP_Middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Middle.Location = new System.Drawing.Point(3, 203);
            this.TLP_Middle.Name = "TLP_Middle";
            this.TLP_Middle.RowCount = 1;
            this.TLP_Middle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Middle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.TLP_Middle.Size = new System.Drawing.Size(826, 204);
            this.TLP_Middle.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(553, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Versions corrigées";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.CB_FixVersions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV_FixVersions, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 174);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CB_FixVersions
            // 
            this.CB_FixVersions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_FixVersions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_FixVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_FixVersions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_FixVersions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FixVersions.FormattingEnabled = true;
            this.CB_FixVersions.Location = new System.Drawing.Point(3, 3);
            this.CB_FixVersions.Name = "CB_FixVersions";
            this.CB_FixVersions.Size = new System.Drawing.Size(258, 25);
            this.CB_FixVersions.TabIndex = 0;
            this.ToolTips.SetToolTip(this.CB_FixVersions, "Selection d\'une version corrigée à être ajoutée à la liste. (Aucun ajout possible" +
        " ici)");
            this.CB_FixVersions.SelectedIndexChanged += new System.EventHandler(this.CB_FixVersions_SelectedIndexChanged);
            this.CB_FixVersions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CB_FixVersions_KeyDown);
            // 
            // DGV_FixVersions
            // 
            this.DGV_FixVersions.AllowDrop = true;
            this.DGV_FixVersions.AllowUserToAddRows = false;
            this.DGV_FixVersions.AllowUserToResizeColumns = false;
            this.DGV_FixVersions.AllowUserToResizeRows = false;
            this.DGV_FixVersions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_FixVersions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_FixVersions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_FixVersions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_FixVersions.ColumnHeadersVisible = false;
            this.DGV_FixVersions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.DGV_FixVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_FixVersions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_FixVersions.Location = new System.Drawing.Point(3, 33);
            this.DGV_FixVersions.Name = "DGV_FixVersions";
            this.DGV_FixVersions.RowHeadersVisible = false;
            this.DGV_FixVersions.Size = new System.Drawing.Size(258, 168);
            this.DGV_FixVersions.TabIndex = 1;
            this.DGV_FixVersions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Labels";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // TLP_Bottom
            // 
            this.TLP_Bottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_Bottom.ColumnCount = 2;
            this.TLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.TLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Bottom.Controls.Add(this.BTN_GO, 0, 0);
            this.TLP_Bottom.Controls.Add(this.RTB_Log, 1, 0);
            this.TLP_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Bottom.Location = new System.Drawing.Point(3, 413);
            this.TLP_Bottom.Name = "TLP_Bottom";
            this.TLP_Bottom.RowCount = 1;
            this.TLP_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Bottom.Size = new System.Drawing.Size(826, 85);
            this.TLP_Bottom.TabIndex = 1;
            // 
            // BTN_GO
            // 
            this.BTN_GO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_GO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_GO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_GO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_GO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_GO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GO.Location = new System.Drawing.Point(3, 3);
            this.BTN_GO.Name = "BTN_GO";
            this.BTN_GO.Size = new System.Drawing.Size(102, 79);
            this.BTN_GO.TabIndex = 0;
            this.BTN_GO.Text = "Créer le site";
            this.ToolTips.SetToolTip(this.BTN_GO, "Bouton pour lancer la requête de création de site à Jira.");
            this.BTN_GO.UseVisualStyleBackColor = false;
            this.BTN_GO.Click += new System.EventHandler(this.BTN_GO_Click);
            // 
            // RTB_Log
            // 
            this.RTB_Log.BackColor = System.Drawing.Color.White;
            this.RTB_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Log.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Log.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RTB_Log.Location = new System.Drawing.Point(111, 3);
            this.RTB_Log.Name = "RTB_Log";
            this.RTB_Log.ReadOnly = true;
            this.RTB_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RTB_Log.Size = new System.Drawing.Size(797, 79);
            this.RTB_Log.TabIndex = 1;
            this.RTB_Log.Text = "Bienvenue sur le script de céation de sites Jira!\nVeuillez entrer toutes les info" +
    "rmations nécessaires et appuyez sur \"Créer le site\".";
            this.ToolTips.SetToolTip(this.RTB_Log, "Informations sur le status du script.");
            this.RTB_Log.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RTB_Log_LinkClicked);
            // 
            // ToolTips
            // 
            this.ToolTips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // JiraCreationSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 501);
            this.Controls.Add(this.TLP_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(848, 539);
            this.Name = "JiraCreationSite";
            this.Text = "Création de sites Jira";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JiraCreationSite_FormClosing);
            this.GB_Components.ResumeLayout(false);
            this.TLP_Components.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Components)).EndInit();
            this.GB_Labels.ResumeLayout(false);
            this.TLP_Labels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Labels)).EndInit();
            this.TLP_Main.ResumeLayout(false);
            this.TLP_Top.ResumeLayout(false);
            this.GB_Infos.ResumeLayout(false);
            this.GB_Infos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ID)).EndInit();
            this.TLP_Middle.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FixVersions)).EndInit();
            this.TLP_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GB_Components;
        private System.Windows.Forms.GroupBox GB_Labels;
        private System.Windows.Forms.TableLayoutPanel TLP_Main;
        private System.Windows.Forms.TableLayoutPanel TLP_Top;
        private System.Windows.Forms.GroupBox GB_Infos;
        private System.Windows.Forms.ComboBox CB_Asignee;
        private System.Windows.Forms.Label LBL_Assignee;
        private System.Windows.Forms.Label LBL_Status;
        private System.Windows.Forms.ComboBox CB_Status;
        private System.Windows.Forms.TextBox TB_Occupation;
        private System.Windows.Forms.Label LBL_Occupation;
        private System.Windows.Forms.TextBox TB_Adress;
        private System.Windows.Forms.NumericUpDown NUD_ID;
        private System.Windows.Forms.Label LBL_Adresse;
        private System.Windows.Forms.Label LBL_ID;
        private System.Windows.Forms.TableLayoutPanel TLP_Middle;
        private System.Windows.Forms.DataGridView DGV_Components;
        private System.Windows.Forms.TableLayoutPanel TLP_Components;
        private System.Windows.Forms.TableLayoutPanel TLP_Labels;
        private System.Windows.Forms.DataGridView DGV_Labels;
        private System.Windows.Forms.ComboBox CB_Components;
        private System.Windows.Forms.ComboBox CB_Labels;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelsCol;
        private System.Windows.Forms.Label LBL_Infos;
        private System.Windows.Forms.TextBox TB_MoreInfos;
        private System.Windows.Forms.Label LBL_MoreInfos;
        private System.Windows.Forms.ComboBox CB_Reporter;
        private System.Windows.Forms.Label LBL_Reporter;
        private System.Windows.Forms.TableLayoutPanel TLP_Bottom;
        private System.Windows.Forms.Button BTN_GO;
        private System.Windows.Forms.RichTextBox RTB_Log;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CB_FixVersions;
        private System.Windows.Forms.DataGridView DGV_FixVersions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

