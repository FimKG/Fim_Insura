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

        private void UC_Rv_Product_Load(object sender, EventArgs e)
        {
            using (Insura_Context db = new Insura_Context())
            {
                var query = (from product in db.ProductTB
                             select product).ToList();

                dgvProdList.DataSource = query;
            }
        }
    }
}
