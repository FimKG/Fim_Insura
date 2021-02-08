using Fim_Insura.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Fim_Insura.webApi;
using System.Collections;

namespace Fim_Insura.user_Control
{
    public partial class UC_Rv_Product : UserControl
    {
        public UC_Rv_Product()
        {
            InitializeComponent();
        }
        public static UC_Rv_Product _instance;
        public static UC_Rv_Product Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Rv_Product();
                return _instance;
            }
        }
        //ListViewItem list = new ListViewItem();
        //list.SubItems.Add(prod.Period);
        //        list.SubItems.Add(prod.PremiumPrice);
        //        list.SubItems.Add(prod.ProductName);
        //        Control.Add(list);
        //private void UC_Rv_Product_Load(object sender, EventArgs e)
        //{
        //    //this.dgvProdList
        //    //using (Insura_Context db = new Insura_Context())
        //    //{
        //    //    var query = (from product in db.productTB
        //    //                 select product).ToList();
        //    //    //var prod = query.FirstOrDefault<ProductTB>();


        //    //    foreach (var listItem in query)
        //    //    {

        //    //    }
        //    //}
        //}

        private void UC_Rv_Product_Load(object sender, EventArgs e)
        {
            using (Insura_Context db = new Insura_Context())
            {
                List<DataGridViewRow> list = new List<DataGridViewRow>(
                from DataGridViewRow product in db.productTB
                select product
                );
            }
        }
    }
}
