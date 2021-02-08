
namespace Fim_Insura
{
    partial class client_Main
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
            this.claim = new System.Windows.Forms.Button();
            this.revProduct = new System.Windows.Forms.Button();
            this.clientProfile = new System.Windows.Forms.Button();
            this.insurProduct = new System.Windows.Forms.Button();
            this.dockedPanel = new System.Windows.Forms.Panel();
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
            // claim
            // 
            this.claim.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.claim.Location = new System.Drawing.Point(45, 222);
            this.claim.Name = "claim";
            this.claim.Size = new System.Drawing.Size(218, 33);
            this.claim.TabIndex = 3;
            this.claim.Text = "Submit a Claim";
            this.claim.UseVisualStyleBackColor = true;
            this.claim.Click += new System.EventHandler(this.claim_Click);
            // 
            // revProduct
            // 
            this.revProduct.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.revProduct.Location = new System.Drawing.Point(45, 271);
            this.revProduct.Name = "revProduct";
            this.revProduct.Size = new System.Drawing.Size(218, 33);
            this.revProduct.TabIndex = 3;
            this.revProduct.Text = "Review Products";
            this.revProduct.UseVisualStyleBackColor = true;
            this.revProduct.Click += new System.EventHandler(this.revProduct_Click);
            // 
            // clientProfile
            // 
            this.clientProfile.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.clientProfile.Location = new System.Drawing.Point(45, 319);
            this.clientProfile.Name = "clientProfile";
            this.clientProfile.Size = new System.Drawing.Size(218, 33);
            this.clientProfile.TabIndex = 3;
            this.clientProfile.Text = "Profile";
            this.clientProfile.UseVisualStyleBackColor = true;
            this.clientProfile.Click += new System.EventHandler(this.clientProfile_Click);
            // 
            // insurProduct
            // 
            this.insurProduct.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.insurProduct.Location = new System.Drawing.Point(45, 171);
            this.insurProduct.Name = "insurProduct";
            this.insurProduct.Size = new System.Drawing.Size(218, 33);
            this.insurProduct.TabIndex = 3;
            this.insurProduct.Text = "Insure Product";
            this.insurProduct.UseVisualStyleBackColor = true;
            this.insurProduct.Click += new System.EventHandler(this.insurProduct_Click);
            // 
            // dockedPanel
            // 
            this.dockedPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dockedPanel.Font = new System.Drawing.Font("Verdana", 9F);
            this.dockedPanel.Location = new System.Drawing.Point(268, 61);
            this.dockedPanel.Name = "dockedPanel";
            this.dockedPanel.Size = new System.Drawing.Size(589, 407);
            this.dockedPanel.TabIndex = 4;
            // 
            // client_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 503);
            this.Controls.Add(this.dockedPanel);
            this.Controls.Add(this.clientProfile);
            this.Controls.Add(this.revProduct);
            this.Controls.Add(this.claim);
            this.Controls.Add(this.insurProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "client_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "client Main";
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
        private System.Windows.Forms.Button claim;
        private System.Windows.Forms.Button revProduct;
        private System.Windows.Forms.Button clientProfile;
        private System.Windows.Forms.Button insurProduct;
        private System.Windows.Forms.Panel dockedPanel;
    }
}