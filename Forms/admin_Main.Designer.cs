
namespace Fim_Insura
{
    partial class admin_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_header = new System.Windows.Forms.Panel();
            this.lbl_LogOut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dockedPanel = new System.Windows.Forms.Panel();
            this.btnAddPolicy = new System.Windows.Forms.Button();
            this.btnClientsView = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnViewPolicy = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_header.Controls.Add(this.lbl_LogOut);
            this.panel_header.Controls.Add(this.label2);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(857, 61);
            this.panel_header.TabIndex = 0;
            // 
            // lbl_LogOut
            // 
            this.lbl_LogOut.AutoSize = true;
            this.lbl_LogOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_LogOut.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.lbl_LogOut.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_LogOut.Location = new System.Drawing.Point(751, 25);
            this.lbl_LogOut.Name = "lbl_LogOut";
            this.lbl_LogOut.Size = new System.Drawing.Size(90, 27);
            this.lbl_LogOut.TabIndex = 16;
            this.lbl_LogOut.Text = "LogOut";
            this.lbl_LogOut.Click += new System.EventHandler(this.lbl_LogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 32.25F);
            this.label2.Location = new System.Drawing.Point(339, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 52);
            this.label2.TabIndex = 15;
            this.label2.Text = "FIM Insura";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 35);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F);
            this.label6.Location = new System.Drawing.Point(690, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Product insurance";
            // 
            // dockedPanel
            // 
            this.dockedPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dockedPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockedPanel.Font = new System.Drawing.Font("Verdana", 9F);
            this.dockedPanel.Location = new System.Drawing.Point(268, 61);
            this.dockedPanel.Name = "dockedPanel";
            this.dockedPanel.Size = new System.Drawing.Size(589, 407);
            this.dockedPanel.TabIndex = 2;
            // 
            // btnAddPolicy
            // 
            this.btnAddPolicy.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnAddPolicy.Location = new System.Drawing.Point(52, 258);
            this.btnAddPolicy.Name = "btnAddPolicy";
            this.btnAddPolicy.Size = new System.Drawing.Size(211, 33);
            this.btnAddPolicy.TabIndex = 4;
            this.btnAddPolicy.Text = "Add Policies";
            this.btnAddPolicy.UseVisualStyleBackColor = true;
            this.btnAddPolicy.Click += new System.EventHandler(this.btnAddPolicy_Click);
            // 
            // btnClientsView
            // 
            this.btnClientsView.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnClientsView.Location = new System.Drawing.Point(52, 209);
            this.btnClientsView.Name = "btnClientsView";
            this.btnClientsView.Size = new System.Drawing.Size(211, 33);
            this.btnClientsView.TabIndex = 5;
            this.btnClientsView.Text = "View Clients";
            this.btnClientsView.UseVisualStyleBackColor = true;
            this.btnClientsView.Click += new System.EventHandler(this.btnClientsView_Click);
            // 
            // btnManage
            // 
            this.btnManage.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnManage.Location = new System.Drawing.Point(52, 158);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(211, 33);
            this.btnManage.TabIndex = 6;
            this.btnManage.Text = "Manage Clients";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnViewPolicy
            // 
            this.btnViewPolicy.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnViewPolicy.Location = new System.Drawing.Point(52, 310);
            this.btnViewPolicy.Name = "btnViewPolicy";
            this.btnViewPolicy.Size = new System.Drawing.Size(211, 33);
            this.btnViewPolicy.TabIndex = 4;
            this.btnViewPolicy.Text = "View Policies";
            this.btnViewPolicy.UseVisualStyleBackColor = true;
            this.btnViewPolicy.Click += new System.EventHandler(this.btnViewPolicy_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnProfile.Location = new System.Drawing.Point(52, 361);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(211, 33);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // admin_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 503);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnViewPolicy);
            this.Controls.Add(this.btnAddPolicy);
            this.Controls.Add(this.btnClientsView);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.dockedPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin Main";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lbl_LogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel dockedPanel;
        private System.Windows.Forms.Button btnAddPolicy;
        private System.Windows.Forms.Button btnClientsView;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnViewPolicy;
        private System.Windows.Forms.Button btnProfile;
    }
}