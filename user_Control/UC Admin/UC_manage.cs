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
    public partial class UC_manage : UserControl
    {
        public UC_manage()
        {
            InitializeComponent();
        }
        public static UC_manage _instance;
        public static UC_manage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_manage();
                return _instance;
            }
        }
    }
}
