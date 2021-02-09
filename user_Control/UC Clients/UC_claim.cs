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

        Insura_Context db = new Insura_Context();
        ProductTB pt = new ProductTB();

        public UC_claim()
        {
            InitializeComponent();
            cbCoverValue.DataSource = (from product in db.ProductTB
                         select product).ToList();
            //cbCoverValue.ValueMember = "Guid.NewGuid()";
            cbCoverValue.DisplayMember = "ProductName";
        }

        public void grid(string cbName)
        {
            var query = (from product in db.ProductTB
                         where product.Id == Guid.NewGuid()
                         select new
                         {
                             product.ProductName,
                             product.Period,
                             product.PremiumPrice
                         }).ToList();

            gvClaim.DataSource = query;
        }

        private void btnInsured_Click(object sender, EventArgs e)
        {

        }

        private void cbCoverValue_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //var query = from cb in db.ProductTB
            //            where cb.Id == pt.Id
            //            select cb;
            //gvClaim.DataSource = query.ToList();
            grid((cbCoverValue.ValueMember));
        }
    }
}
