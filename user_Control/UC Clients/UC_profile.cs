using Fim_Insura.Forms;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (Insura_Context db = new Insura_Context())
            {
                var query = from clients in db.ClientTB
                            where clients.Id = txtnames.Text
                            select clients
                //ClientTB client = new ClientTB()
                //{
                //    Fname = txt
                //}
                db.ClientTB.Add(query);
                if (db.ChangeTracker.HasChanges())
                {
                    db.SaveChanges();
                    lblError.Text = "Successfully Updated";
                }
            }
        }
    }
}
