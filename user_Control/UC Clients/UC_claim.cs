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
        Insura_Context db = new Insura_Context();
        private void cbCoverValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var query = (from product in db.productTB
                         where product.ProductName == cbCoverValue.Text
                         select product).ToList();

            gvClaim.DataSource = query;
            //DataBind();
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

        //public void grid(object cbName)
        //{
        //        var query = (from product in db.productTB
        //                     where product.ProductName == cbName
        //                     select product).ToList();

        //        gvClaim.DataSource = query;
        //    //DataBind();
        //}

        private void btnInsured_Click(object sender, EventArgs e)
        {

        }

        private void UC_claim_Load(object sender, EventArgs e)
        {

            //if (!IsPostBack)
            //{
                var query = (from product in db.productTB
                             select new
                             {
                                 product.ProductName
                             });
            //}

                //cbCoverValue.Items.Add(query);

            
        }
    }
}
