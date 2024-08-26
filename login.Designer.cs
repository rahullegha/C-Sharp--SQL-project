namespace D2
{
    partial class login
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLoginPage = new System.Windows.Forms.Label();
            this.comboBoxloginmode = new System.Windows.Forms.ComboBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsername.Location = new System.Drawing.Point(68, 187);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(225, 32);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Enter the Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPassword.Location = new System.Drawing.Point(68, 234);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(215, 32);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Enter the Password";
            this.labelPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(422, 198);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(286, 23);
            this.textBoxusername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(422, 245);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(286, 23);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelLoginPage
            // 
            this.labelLoginPage.AutoSize = true;
            this.labelLoginPage.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginPage.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoginPage.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLoginPage.Location = new System.Drawing.Point(274, 33);
            this.labelLoginPage.Name = "labelLoginPage";
            this.labelLoginPage.Size = new System.Drawing.Size(291, 65);
            this.labelLoginPage.TabIndex = 4;
            this.labelLoginPage.Text = "Login Page ";
            this.labelLoginPage.Click += new System.EventHandler(this.labelLoginPage_Click);
            // 
            // comboBoxloginmode
            // 
            this.comboBoxloginmode.BackColor = System.Drawing.Color.White;
            this.comboBoxloginmode.FormattingEnabled = true;
            this.comboBoxloginmode.Items.AddRange(new object[] {
            "Staff Login",
            "Customer Login"});
            this.comboBoxloginmode.Location = new System.Drawing.Point(422, 150);
            this.comboBoxloginmode.Name = "comboBoxloginmode";
            this.comboBoxloginmode.Size = new System.Drawing.Size(286, 23);
            this.comboBoxloginmode.TabIndex = 5;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(547, 350);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(130, 45);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.BackColor = System.Drawing.Color.Transparent;
            this.labelMode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMode.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMode.Location = new System.Drawing.Point(68, 141);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(256, 32);
            this.labelMode.TabIndex = 7;
            this.labelMode.Text = "Select the Login Mode";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(334, 350);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 45);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.Location = new System.Drawing.Point(54, 350);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(208, 45);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Register Now";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.BackColor = System.Drawing.Color.Transparent;
            this.labelerror.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelerror.ForeColor = System.Drawing.Color.Red;
            this.labelerror.Location = new System.Drawing.Point(68, 299);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(194, 20);
            this.labelerror.TabIndex = 10;
            this.labelerror.Text = "* Email Id is your Username \r\n";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::D2.Properties.Resources.pxfuel__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 472);
            this.Controls.Add(this.labelerror);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.comboBoxloginmode);
            this.Controls.Add(this.labelLoginPage);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelLoginPage;
        private ComboBox comboBoxloginmode;
        private Button buttonLogin;
        private Label labelMode;
        private Button buttonClear;
        private Button buttonRegister;
        private Label labelerror;
        public TextBox textBoxusername;
    }
}