using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fim_Insura.user_Control.UC_Admin
{
    public partial class UC_AddPolicy : UserControl
    {
        public UC_AddPolicy()
        {
            InitializeComponent();
        }
        public static UC_AddPolicy _instance;
        public static UC_AddPolicy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_AddPolicy();
                return _instance;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
