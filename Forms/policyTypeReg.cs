using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fim_Insura
{
    public partial class policyTypeReg : Form
    {
        public policyTypeReg()
        {
            InitializeComponent();
            cbCoverValue.SelectedIndex = 0;
        }

        policy policy = new policy();
        
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnames_Click(object sender, EventArgs e)
        {
            txtnames.Clear();
            txtnames.BackColor = Color.FromArgb(20, 155, 163);
            panel1.BackColor = Color.FromArgb(20, 155, 163);
            lblfName.Text = "First Name";
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            txtLastName.Clear();
            txtLastName.BackColor = Color.FromArgb(20, 155, 163);
            panel2.BackColor = Color.FromArgb(20, 155, 163);
            lblLastName.Text = "Last Name";
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtAddress.BackColor = Color.FromArgb(20, 155, 163);
            panel3.BackColor = Color.FromArgb(20, 155, 163);
            lblAddress.Text = "Address";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtEmail.BackColor = Color.FromArgb(20, 155, 163);
            panel4.BackColor = Color.FromArgb(20, 155, 163);
            lblEmail.Text = "Email";
        }

        private void txtCell_Click(object sender, EventArgs e)
        {
            txtCell.Clear();
            txtCell.BackColor = Color.FromArgb(20, 155, 163);
            panel5.BackColor = Color.FromArgb(20, 155, 163);
            lblCell.Text = "Cellphone";
        }

        private void txtDateOfBirth_Click(object sender, EventArgs e)
        {
            txtDateOfBirth.Clear();
            txtDateOfBirth.BackColor = Color.FromArgb(20, 155, 163);
            panel6.BackColor = Color.FromArgb(20, 155, 163);
            lblBirthDate.Text = "Date Of Birth";
        }

        private void txtPolicyPeriod_Click(object sender, EventArgs e)
        {
            txtPolicyPeriod.Clear();
            txtPolicyPeriod.BackColor = Color.FromArgb(20, 155, 163);
            panel7.BackColor = Color.FromArgb(20, 155, 163);
            lblPolicy.Text = "PolicyPeriod";
        }

        private void btnCalculatePolicy_Click(object sender, EventArgs e)
        {
            double coverValue = Convert.ToDouble(cbCoverValue.SelectedItem);
            lbltotal.Text = (((coverValue * 0.25) + coverValue ) * double.Parse(txtPolicyPeriod.Text)).ToString();
        }

        private void btnLogPolicy_Click(object sender, EventArgs e)
        {
            client_Main logPolicy = new client_Main();

            logPolicy.Show();
        }
    }
}
