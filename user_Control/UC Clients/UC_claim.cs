using Fim_Insura.Forms;
using Fim_Insura.webApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Fim_Insura.user_Control
{
    public partial class UC_claim : UserControl
    {
        public UC_claim()
        {
            InitializeComponent();

        }

        private void cbCoverValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static UC_claim _instance;
        public static UC_claim Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_claim();
                return _instance;
            }
        }

        public void grid()
        {

            using (Insura_Context db = new Insura_Context())
            {
                gvClaim.DataSource = from product in db.productTB
                            //where product.ProductName ==
                            select product;
                _ = gvClaim.DataBindings;

            }
        }

        private void btnInsured_Click(object sender, EventArgs e)
        {

        }
    }
}
