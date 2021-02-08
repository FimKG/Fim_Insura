using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fim_Insura.user_Control
{
    public partial class UC_profile : UserControl
    {
        public UC_profile()
        {
            InitializeComponent();
        }
        public static UC_profile _instance;
        public static UC_profile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_profile();
                return _instance;
            }
        }
    }
}
