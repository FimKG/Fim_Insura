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

        private UC_InsuraPro insuraPro = new UC_InsuraPro()
        {
            Visible = false
        };
                
        private UC_claim claimer = new UC_claim()
        {
            Visible = false
        };
                
        private UC_profile prof = new UC_profile()
        {
            Visible = false
        };

        private UC_Rv_Product rv = new UC_Rv_Product()
        {
            Visible = false
        };

        private void VisualizeUC(Control value)
        {
            insuraPro.Visible = false;
            claimer.Visible = false;
            prof.Visible = false;
            prof.Visible = false;
            rv.Visible = false;

            value.Visible = true;
        }
        private void lbl_LogOut_Click(object sender, EventArgs e)
        {
            landing landing = new landing();
            this.Hide();
            landing.Show();
        }

        private void client_Main_Load(object sender, EventArgs e)
        {
            Controls.Add(insuraPro);
            Controls.Add(claimer);
            Controls.Add(prof);
            Controls.Add(rv);
        }

        private void insurProduct_Click(object sender, EventArgs e)
        {
            //InsureProduct insura = new InsureProduct();
            //insura.Show();
            VisualizeUC(insuraPro);
        }

        private void claim_Click(object sender, EventArgs e)
        {
            VisualizeUC(claimer);
        }

        private void revProduct_Click(object sender, EventArgs e)
        {
            VisualizeUC(rv);
        }

        private void clientProfile_Click(object sender, EventArgs e)
        {
            VisualizeUC(prof);
        }
    }
}
