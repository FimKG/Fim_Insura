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
    public partial class policyTypeReg : Form
    {
        public policyTypeReg()
        {
            InitializeComponent();
            cbCoverValue.SelectedIndex = 0;
        }
        
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            client_login login = new client_login();
            login.Show();
        }

        private void txtnames_Click(object sender, EventArgs e)
        {
            //txtnames.Clear();
            //txtnames.BackColor = Color.FromArgb(20, 155, 163);
            //panel1.BackColor = Color.FromArgb(20, 155, 163);
            lblfName.Text = "First Name";
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            //txtLastName.Clear();
            //txtLastName.BackColor = Color.FromArgb(20, 155, 163);
            //panel2.BackColor = Color.FromArgb(20, 155, 163);
            lblLastName.Text = "Last Name";
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            //txtAddress.Clear();
            //txtAddress.BackColor = Color.FromArgb(20, 155, 163);
            //panel3.BackColor = Color.FromArgb(20, 155, 163);
            lblAddress.Text = "Address";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            //txtEmail.Clear();
            //txtEmail.BackColor = Color.FromArgb(20, 155, 163);
            //panel4.BackColor = Color.FromArgb(20, 155, 163);
            lblEmail.Text = "Email";
        }

        private void txtCell_Click(object sender, EventArgs e)
        {
            //txtCell.Clear();
            //txtCell.BackColor = Color.FromArgb(20, 155, 163);
            //panel5.BackColor = Color.FromArgb(20, 155, 163);
            lblCell.Text = "Cellphone";
        }

        private void txtDateOfBirth_Click(object sender, EventArgs e)
        {
            //txtDateOfBirth.Clear();
            //txtDateOfBirth.BackColor = Color.FromArgb(20, 155, 163);
            //panel6.BackColor = Color.FromArgb(20, 155, 163);
            lblBirthDate.Text = "Date Of Birth";
        }

        private void txtPolicyPeriod_Click(object sender, EventArgs e)
        {
            //txtPolicyPeriod.Clear();
            //txtPolicyPeriod.BackColor = Color.FromArgb(20, 155, 163);
            //panel7.BackColor = Color.FromArgb(20, 155, 163);
            lblPolicy.Text = "PolicyPeriod";
        }

        private void btnCalculatePolicy_Click(object sender, EventArgs e)
        {
            double coverValue = Convert.ToDouble(cbCoverValue.SelectedItem);
            lbltotal.Text = "Your Premium is valued at R" + (((coverValue * 0.25) + coverValue ) * double.Parse(txtPolicyPeriod.Text)).ToString();
        }

        private void btnLogPolicy_Click(object sender, EventArgs e)
        {
            client_Main logPolicy = new client_Main();
            using (Insura_Context db = new Insura_Context())
            {
                ClientTB clienttb = new ClientTB()
                {
                    Id = Guid.NewGuid(),
                    Fname = txtnames.Text,
                    Lname = txtLastname.Text,
                    Adress = txtAddress.Text,
                    Email = txtEmail.Text,
                    DOB = callDob.Text,
                    Cellphone = txtCell.Text,
                    Password = txtPassword.Text,
                    AmendedOn = DateTime.Now,
                    CreatedOn = DateTime.Now

                };
                //if (db.adminTB.Find(admintb.Email) != null)
                //{
                //    lblError.Text = "Email Already taken";
                //}
                //else
                //{
                db.ClientTB.Add(clienttb);
                if (db.ChangeTracker.HasChanges())
                {
                    db.SaveChanges();
                    lblError.Text = "Successfully registered";
                }

                //}            
                this.Hide();
                logPolicy.Show();
            }

            
        }
    }
}
