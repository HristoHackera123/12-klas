namespace PasswordChecker
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            userControl11 = new LoginControl();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(220, 154);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(111, 43);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // userControl11
            // 
            userControl11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userControl11.Location = new Point(14, 14);
            userControl11.Margin = new Padding(5);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(460, 274);
            userControl11.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 302);
            Controls.Add(userControl11);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private LoginControl userControl11;
    }
}
