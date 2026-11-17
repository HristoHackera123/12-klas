using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PasswordChecker
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            lblSuccess.Hide();
            lblSuccess.ForeColor = Color.Green;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters long.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            lblSuccess.Show();
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            lblSuccess.Hide();
        }
    }
}
