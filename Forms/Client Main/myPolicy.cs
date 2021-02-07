using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fim_Insura.Forms
{
    public partial class myPolicy : Form
    {
        public myPolicy()
        {
            InitializeComponent();
        }

        private void txtnames_Click(object sender, EventArgs e)
        {
            txtnames.Clear();
            txtnames.BackColor = Color.FromArgb(20, 155, 163);
            panel1.BackColor = Color.FromArgb(20, 155, 163);
            lblfName.Text = "Enter First name to search";
        }
    }
}
