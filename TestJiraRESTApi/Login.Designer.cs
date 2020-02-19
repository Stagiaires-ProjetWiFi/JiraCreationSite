namespace JiraCreationSite
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.LBL_Username = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.GB_JiraLogin = new System.Windows.Forms.GroupBox();
            this.LKLBL_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.LKLBL_Admin = new System.Windows.Forms.LinkLabel();
            this.LBL_NewMember2 = new System.Windows.Forms.Label();
            this.LBL_NewMember1 = new System.Windows.Forms.Label();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EP_LoginErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.GB_JiraLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_LoginErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(203, 105);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(165, 25);
            this.TB_Password.TabIndex = 0;
            // 
            // LBL_Username
            // 
            this.LBL_Username.AutoSize = true;
            this.LBL_Username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Username.Location = new System.Drawing.Point(33, 77);
            this.LBL_Username.Name = "LBL_Username";
            this.LBL_Username.Size = new System.Drawing.Size(164, 17);
            this.LBL_Username.TabIndex = 1;
            this.LBL_Username.Text = "Nom d\'utilisateur (Code U)";
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Password.Location = new System.Drawing.Point(108, 108);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(89, 17);
            this.LBL_Password.TabIndex = 2;
            this.LBL_Password.Text = "Mot de passe";
            // 
            // TB_Username
            // 
            this.TB_Username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(203, 74);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(165, 25);
            this.TB_Username.TabIndex = 3;
            // 
            // GB_JiraLogin
            // 
            this.GB_JiraLogin.Controls.Add(this.LKLBL_ForgotPassword);
            this.GB_JiraLogin.Controls.Add(this.BTN_Login);
            this.GB_JiraLogin.Controls.Add(this.LKLBL_Admin);
            this.GB_JiraLogin.Controls.Add(this.LBL_NewMember2);
            this.GB_JiraLogin.Controls.Add(this.LBL_NewMember1);
            this.GB_JiraLogin.Controls.Add(this.LBL_Title);
            this.GB_JiraLogin.Controls.Add(this.LBL_Username);
            this.GB_JiraLogin.Controls.Add(this.TB_Password);
            this.GB_JiraLogin.Controls.Add(this.LBL_Password);
            this.GB_JiraLogin.Controls.Add(this.TB_Username);
            this.GB_JiraLogin.Location = new System.Drawing.Point(53, 44);
            this.GB_JiraLogin.Name = "GB_JiraLogin";
            this.GB_JiraLogin.Size = new System.Drawing.Size(471, 321);
            this.GB_JiraLogin.TabIndex = 5;
            this.GB_JiraLogin.TabStop = false;
            // 
            // LKLBL_ForgotPassword
            // 
            this.LKLBL_ForgotPassword.AutoSize = true;
            this.LKLBL_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKLBL_ForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.LKLBL_ForgotPassword.Location = new System.Drawing.Point(108, 248);
            this.LKLBL_ForgotPassword.Name = "LKLBL_ForgotPassword";
            this.LKLBL_ForgotPassword.Size = new System.Drawing.Size(279, 17);
            this.LKLBL_ForgotPassword.TabIndex = 9;
            this.LKLBL_ForgotPassword.TabStop = true;
            this.LKLBL_ForgotPassword.Text = "Vous ne pouvez pas accéder à votre compte ?";
            this.LKLBL_ForgotPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.LKLBL_ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKLBL_ForgotPassword_LinkClicked);
            // 
            // BTN_Login
            // 
            this.BTN_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.BTN_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.BTN_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.BTN_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.BTN_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Login.Location = new System.Drawing.Point(111, 204);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(90, 30);
            this.BTN_Login.TabIndex = 8;
            this.BTN_Login.Text = "Connexion";
            this.BTN_Login.UseVisualStyleBackColor = false;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // LKLBL_Admin
            // 
            this.LKLBL_Admin.AutoSize = true;
            this.LKLBL_Admin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKLBL_Admin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.LKLBL_Admin.Location = new System.Drawing.Point(239, 174);
            this.LKLBL_Admin.Name = "LKLBL_Admin";
            this.LKLBL_Admin.Size = new System.Drawing.Size(125, 17);
            this.LKLBL_Admin.TabIndex = 7;
            this.LKLBL_Admin.TabStop = true;
            this.LKLBL_Admin.Text = "administrateurs Jira.";
            this.LKLBL_Admin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.LKLBL_Admin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKLBL_Admin_LinkClicked);
            // 
            // LBL_NewMember2
            // 
            this.LBL_NewMember2.AutoSize = true;
            this.LBL_NewMember2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NewMember2.Location = new System.Drawing.Point(108, 174);
            this.LBL_NewMember2.Name = "LBL_NewMember2";
            this.LBL_NewMember2.Size = new System.Drawing.Size(138, 17);
            this.LBL_NewMember2.TabIndex = 6;
            this.LBL_NewMember2.Text = "Veuillez contacter vos ";
            // 
            // LBL_NewMember1
            // 
            this.LBL_NewMember1.AutoSize = true;
            this.LBL_NewMember1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NewMember1.Location = new System.Drawing.Point(108, 157);
            this.LBL_NewMember1.Name = "LBL_NewMember1";
            this.LBL_NewMember1.Size = new System.Drawing.Size(299, 17);
            this.LBL_NewMember1.TabIndex = 5;
            this.LBL_NewMember1.Text = "Pas encore membre ? Pour demander un compte,";
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(6, 16);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(243, 32);
            this.LBL_Title.TabIndex = 4;
            this.LBL_Title.Text = "Bienvenue dans Jira";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Connexion vers Jira";
            // 
            // EP_LoginErrorMessage
            // 
            this.EP_LoginErrorMessage.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EP_LoginErrorMessage.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GB_JiraLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(602, 419);
            this.MinimumSize = new System.Drawing.Size(602, 419);
            this.Name = "Login";
            this.Text = "Jira Creation Site";
            this.GB_JiraLogin.ResumeLayout(false);
            this.GB_JiraLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_LoginErrorMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label LBL_Username;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.GroupBox GB_JiraLogin;
        private System.Windows.Forms.Label LBL_NewMember1;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.LinkLabel LKLBL_Admin;
        private System.Windows.Forms.Label LBL_NewMember2;
        private System.Windows.Forms.LinkLabel LKLBL_ForgotPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider EP_LoginErrorMessage;
    }
}