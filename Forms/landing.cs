using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fim_Insura.Forms
{
    public partial class landing : Form
    {
        public landing()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            client_login client_login = new client_login();
            client_login.Show();
            this.Hide();
        }


    }
}
