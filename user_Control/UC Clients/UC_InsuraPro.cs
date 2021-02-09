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
    public partial class UC_InsuraPro : UserControl
    {
        public static UC_InsuraPro _instance;
        public static UC_InsuraPro Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new UC_InsuraPro();
                return _instance;
            }
        }

        public UC_InsuraPro()
        {
            InitializeComponent();
        }

        private void txtPolicyPeriod_TextChanged(object sender, EventArgs e)
        {
            double coverValue = Convert.ToDouble(cbCoverValue.SelectedItem);
            btnCalculatePolicy(coverValue, txtPolicyPeriod.Text);
        }
        private void btnCalculatePolicy (double coverValue, string policyPeriod)
        {
            if (policyPeriod.Trim() == "")
            {
                lbltotal.Text = "Policy Period is Empty";
                lbltotal.BackColor = Color.FromArgb(255, 255, 0);
            }
            else
            {
                double d = (((coverValue * 0.25) + coverValue) / 12 * double.Parse(txtPolicyPeriod.Text));
                lbltotal.Text = "Your Premium is valued at R" + Math.Round(d, 2);
                lbltotal.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnInsured_Click(object sender, EventArgs e)
        {

            if (cbCoverValue.SelectedIndex != null && txtPolicyPeriod.Text != "" && txtProductName.Text != "")
            {
            double coverValue = Convert.ToDouble(cbCoverValue.SelectedItem);
            double total = ((coverValue * 0.25) + coverValue) / 12 * double.Parse(txtPolicyPeriod.Text);
            using (Insura_Context db = new Insura_Context())
            {
                ProductTB productTB = new ProductTB()
                {
                    Id = Guid.NewGuid(),
                    CoverValue = (string)cbCoverValue.SelectedItem,
                    Period = txtPolicyPeriod.Text,
                    ProductName = txtProductName.Text,
                    PremiumPrice = Math.Round(total, 2).ToString(),
                    AmendedOn = DateTime.Now,
                    CreatedOn = DateTime.Now

                };
                db.ProductTB.Add(productTB);
                if (db.ChangeTracker.HasChanges())
                {
                    db.SaveChanges();
                    lblError.Text = "Successfully Insured";
                }
                
            }
            }
            else
            {
                lblError.Text = "Invalid Inputs Or Empty fields";
            }
        }

        private void UC_InsuraPro_Load(object sender, EventArgs e)
        {
            cbCoverValue.SelectedIndex = 0;
        }
    }
}
