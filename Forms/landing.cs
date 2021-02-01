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

        //register admin = new register();
        //policyType client = new policyType();
        login login = new login();
        client_login client_login = new client_login();

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            login.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            client_login.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
