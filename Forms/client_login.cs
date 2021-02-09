using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Fim_Insura.Forms
{
    public partial class client_login : Form
    {
        policyTypeReg regFrm = new policyTypeReg();
        public client_login()
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
            //txtUsername.Clear();
            //txtUsername.ForeColor = Color.FromArgb(20, 155, 163);
            //panel1.ForeColor = Color.FromArgb(20, 155, 163);
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            //txtPassword.Clear();
            //txtPassword.ForeColor = Color.FromArgb(20, 155, 163);
            //panel2.ForeColor = Color.FromArgb(20, 155, 163);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (Insura_Context db = new Insura_Context())
            {
                var query = from log in db.ClientTB
                            where log.Email == txtUsername.Text && log.Password == txtPassword.Text
                            select log;
                var clients = query.FirstOrDefault<ClientTB>();

                if (clients != null && clients.Email == txtUsername.Text && clients.Password == txtPassword.Text)
                {
                    client_Main main = new client_Main();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    lblError.Text = "Invalid Username or Password";
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            regFrm.Show();
            this.Hide();
        }
    }
}
