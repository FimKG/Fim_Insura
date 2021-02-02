using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fim_Insura.Forms;

namespace Fim_Insura
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            landing home = new landing();
            home.Show();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtUsername.ForeColor = Color.FromArgb(20, 155, 163);
            panel1.ForeColor = Color.FromArgb(20, 155, 163);
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.ForeColor = Color.FromArgb(20, 155, 163);
            panel2.ForeColor = Color.FromArgb(20, 155, 163);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register admin = new register();
            admin.Show();
            this.Hide();
        }
    }
}
