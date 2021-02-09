﻿using Fim_Insura.Forms;
using Fim_Insura.webApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fim_Insura
{
    public partial class register : Form
    {
        //login loginFrm = new login();
        public register()
        {
            InitializeComponent();
        }
        login log = new login();
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
            log.Show();
        }

        private void txtnames_Click(object sender, EventArgs e)
        {
            txtnames.Clear();
            txtnames.ForeColor = Color.FromArgb(20, 155, 163);
            panel1.ForeColor = Color.FromArgb(20, 155, 163);
        }

        private void txtLastname_Click(object sender, EventArgs e)
        {
            txtLastname.Clear();
            txtLastname.ForeColor = Color.FromArgb(20, 155, 163);
            panel2.ForeColor = Color.FromArgb(20, 155, 163);
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtEmail.ForeColor = Color.FromArgb(20, 155, 163);
            panel3.ForeColor = Color.FromArgb(20, 155, 163);
        }
        private void txtTelno_Click(object sender, EventArgs e)
        {
            txtTelno.Clear();
            txtTelno.ForeColor = Color.FromArgb(20, 155, 163);
            panel4.ForeColor = Color.FromArgb(20, 155, 163);
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.ForeColor = Color.FromArgb(20, 155, 163);
            panel5.ForeColor = Color.FromArgb(20, 155, 163);
        }

        private void cbCondition_MouseCaptureChanged(object sender, EventArgs e)
        {
            lblAgree.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            admin_Main admin = new admin_Main();

            if (cbCondition.Checked == true)
            {
                using(Insura_Context db = new Insura_Context())
                {
                    AdminTB admintb = new AdminTB()
                    {
                        Id = Guid.NewGuid(),
                        Fname = txtnames.Text,
                        Lname = txtLastname.Text,
                        Email = txtEmail.Text,
                        Cellphone = txtTelno.Text,
                        Password = txtPassword.Text,
                        AmendedOn = DateTime.Now,
                        CreatedOn= DateTime.Now
                     
                    };
                    //if (db.adminTB.Find(admintb.Email) != null)
                    //{
                    //    lblError.Text = "Email Already taken";
                    //}
                    //else
                    //{
                        db.AdminTB.Add(admintb);
                        if (db.ChangeTracker.HasChanges())
                        {
                            db.SaveChanges();
                            lblError.Text = "Successfully registered";
                    }
                    else
                    {
                        lblError.Text = "Email Already taken";
                    }
                     
                    //}
                }
                admin.Show();
                this.Hide();
            }
            else
            {
                lblAgree.ForeColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            log.Show();
        }
    }
}
