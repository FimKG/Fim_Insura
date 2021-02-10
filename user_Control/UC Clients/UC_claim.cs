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
            cbCoverValue.DisplayMember = "ProductName";
        }

        public void grid(Guid cbName)
        {
            var query = (from product in db.ProductTB
                         where product.Id == cbName
                         select new
                         {
                             product.ProductName,
                             product.Period,
                             product.PremiumPrice
                         }).ToList();

            gvClaim.DataSource = query;
        }

        public void claim(string prodName, string primPrice)
        {
            ClaimTB cliams = new ClaimTB()
            {
                Id = Guid.NewGuid(),
                ProductName = prodName,
                PremiumPrice = primPrice,
                AmendedOn = DateTime.Now,
                CreatedOn = DateTime.Now

            };

            db.ClaimTB.Add(cliams);
            if (db.ChangeTracker.HasChanges())
            {
                db.SaveChanges();
                lblError.Text = "Successfully Claimed";
            }
        }
        private void cbCoverValue_SelectionChangeCommitted(object sender, EventArgs e)
        {
          var temp= (ProductTB)  cbCoverValue.SelectedItem;
            grid(temp.Id);
        }

        private void gvClaim_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row  in gvClaim.SelectedRows)
            {
                claim(row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
                lblError.Text = row.Cells[1].Value.ToString();
            }
        }        
        
        private void btnInsured_Click(object sender, EventArgs e)
        {

        }
    }
}
