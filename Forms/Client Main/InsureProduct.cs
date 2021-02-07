using Fim_Insura.webApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fim_Insura.Forms
{
    public partial class InsureProduct : Form
    {
        public InsureProduct()
        {
            InitializeComponent();
        }
        private void btnCalculatePolicy(double coverValue, string policyPeriod)
        {
            if(policyPeriod.Trim() == "")
            {
                lbltotal.Text = "Policy Period is Empty";
                lbltotal.BackColor = Color.FromArgb(255,255,0);
            }
            else
            {
                lbltotal.Text = "Your Premium is valued at R" + (((coverValue * 0.25) + coverValue) * double.Parse(txtPolicyPeriod.Text)).ToString();
            }
        }
        private void btnInsured_Click(object sender, EventArgs e)
        {
            double coverValue = Convert.ToDouble(cbCoverValue.SelectedItem);
            string total = (((((coverValue * 0.25) + coverValue) / 12) * double.Parse(txtPolicyPeriod.Text)).ToString()).ToString();
            using (Insura_Context db = new Insura_Context())
            {
                ProductTB productTB = new ProductTB()
                {
                    CoverValue = (string)cbCoverValue.SelectedItem,
                    Period = txtPolicyPeriod.Text,
                    ProductName = txtProductName.Text,
                    PremiumPrice = total,
                    AmendedOn = DateTime.Now,
                    CreatedOn = DateTime.Now

                };
                db.productTB.Add(productTB);
                if (db.ChangeTracker.HasChanges())
                {
                    db.SaveChanges();
                    lblError.Text = "Successfully Insured";
                    lblError.ForeColor = Color.FromArgb(0, 255, 0);
                }
            }
        }

        private void txtPolicyPeriod_TextChanged(object sender, EventArgs e)
        {
            double coverValue = Convert.ToDouble(cbCoverValue.SelectedItem);
            btnCalculatePolicy(coverValue, txtPolicyPeriod.Text);
        }
    }
}
