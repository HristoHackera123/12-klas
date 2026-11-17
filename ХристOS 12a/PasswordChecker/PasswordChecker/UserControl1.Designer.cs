namespace PasswordChecker
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            lblSuccess = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(20, 16);
            lblUsername.Margin = new Padding(5, 0, 5, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.ActiveCaptionText;
            lblPassword.ForeColor = SystemColors.Control;
            lblPassword.Location = new Point(240, 19);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(20, 60);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(179, 33);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txt_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(143, 145);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(151, 41);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblSuccess
            // 
            lblSuccess.AutoSize = true;
            lblSuccess.Location = new Point(178, 211);
            lblSuccess.Name = "lblSuccess";
            lblSuccess.Size = new Size(82, 25);
            lblSuccess.TabIndex = 6;
            lblSuccess.Text = "Success!";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(240, 60);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '?';
            txtPassword.Size = new Size(179, 33);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += txt_TextChanged;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtPassword);
            Controls.Add(lblSuccess);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "LoginControl";
            Size = new Size(460, 283);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label lblSuccess;
        private TextBox txtPassword;
    }
}
