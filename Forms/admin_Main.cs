using Fim_Insura.Forms;
using Fim_Insura.user_Control.UC_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fim_Insura
{
    public partial class admin_Main : Form
    {
        public admin_Main()
        {
            InitializeComponent();
        }
        //landing land = new landing();
        private void lbl_LogOut_Click(object sender, EventArgs e)
        {
            landing landing = new landing();
            this.Hide();
            landing.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if (!dockedPanel.Controls.Contains(UC_manage.Instance))
            {
                dockedPanel.Controls.Add(UC_manage.Instance);
                UC_manage.Instance.Dock = DockStyle.Fill;
                UC_manage.Instance.BringToFront();
            }
            else
            {
                UC_manage.Instance.BringToFront();
            }
        }

        private void btnClientsView_Click(object sender, EventArgs e)
        {
            if (!dockedPanel.Controls.Contains(UC_viewClients.Instance))
            {
                dockedPanel.Controls.Add(UC_viewClients.Instance);
                UC_viewClients.Instance.Dock = DockStyle.Fill;
                UC_viewClients.Instance.BringToFront();
            }
            else
            {
                UC_viewClients.Instance.BringToFront();
            }
        }

        private void btnAddPolicy_Click(object sender, EventArgs e)
        {
            if (!dockedPanel.Controls.Contains(UC_AddPolicy.Instance))
            {
                dockedPanel.Controls.Add(UC_AddPolicy.Instance);
                UC_AddPolicy.Instance.Dock = DockStyle.Fill;
                UC_AddPolicy.Instance.BringToFront();
            }
            else
            {
                UC_AddPolicy.Instance.BringToFront();
            }
        }

        private void btnViewPolicy_Click(object sender, EventArgs e)
        {
            if (!dockedPanel.Controls.Contains(UC_viewPolicy.Instance))
            {
                dockedPanel.Controls.Add(UC_viewPolicy.Instance);
                UC_viewPolicy.Instance.Dock = DockStyle.Fill;
                UC_viewPolicy.Instance.BringToFront();
            }
            else
            {
                UC_viewPolicy.Instance.BringToFront();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (!dockedPanel.Controls.Contains(UC_profile.Instance))
            {
                dockedPanel.Controls.Add(UC_profile.Instance);
                UC_profile.Instance.Dock = DockStyle.Fill;
                UC_profile.Instance.BringToFront();
            }
            else
            {
                UC_profile.Instance.BringToFront();
            }
        }
    }   
}
