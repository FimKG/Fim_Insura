using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fim_Insura
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
