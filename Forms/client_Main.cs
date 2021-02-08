using Fim_Insura.Forms;
using Fim_Insura.user_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fim_Insura
{
    public partial class client_Main : Form
    {
        public client_Main()
        {
            InitializeComponent();
        }

        private void lbl_LogOut_Click(object sender, EventArgs e)
        {
            landing landing = new landing();
            this.Hide();
            landing.Show();
        }

        private void insurProduct_Click(object sender, EventArgs e)
        {
            if (!dockedPanel.Controls.Contains(UC_InsuraPro.Instance))
            {
                dockedPanel.Controls.Add(UC_InsuraPro.Instance);
                UC_InsuraPro.Instance.Dock = DockStyle.Fill;
                UC_InsuraPro.Instance.BringToFront();
            }
            else
            {
                UC_InsuraPro.Instance.BringToFront();
            }
        }

        private void claim_Click(object sender, EventArgs e)
        {
            if (!dockedPanel.Controls.Contains(UC_claim.Instance))
            {
                dockedPanel.Controls.Add(UC_claim.Instance);
                UC_claim.Instance.Dock = DockStyle.Fill;
                UC_claim.Instance.BringToFront();
            }
            else
            {
                UC_claim.Instance.BringToFront();
            }
        }

        private void revProduct_Click(object sender, EventArgs e)
        {
            if (!dockedPanel.Controls.Contains(UC_Rv_Product.Instance))
            {
                dockedPanel.Controls.Add(UC_Rv_Product.Instance);
                UC_Rv_Product.Instance.Dock = DockStyle.Fill;
                UC_Rv_Product.Instance.BringToFront();
            }
            else
            {
                UC_Rv_Product.Instance.BringToFront();
            }
        }

        private void clientProfile_Click(object sender, EventArgs e)
        {
            if (!dockedPanel.Controls.Contains(UC_profile.Instance))
            {
                dockedPanel.Controls.Add(UC_profile.Instance);
                UC_profile.Instance.Dock = DockStyle.Fill;
                UC_profile.Instance.BringToFront();
            }
            else
            {
                UC_profile.Instance.BringToFront();
            }
        }
    }
}
