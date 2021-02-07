
namespace Fim_Insura.Forms
{
    partial class InsureProduct
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
            this.lbltotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCoverValue = new System.Windows.Forms.ComboBox();
            this.btnInsured = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtPolicyPeriod = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lbltotal.Location = new System.Drawing.Point(159, 257);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 23);
            this.lbltotal.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 32.25F);
            this.label2.Location = new System.Drawing.Point(70, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 52);
            this.label2.TabIndex = 48;
            this.label2.Text = "Insure Your Product";
            // 
            // cbCoverValue
            // 
            this.cbCoverValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCoverValue.Font = new System.Drawing.Font("Verdana", 12F);
            this.cbCoverValue.FormattingEnabled = true;
            this.cbCoverValue.Items.AddRange(new object[] {
            "Select Cover Value",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000"});
            this.cbCoverValue.Location = new System.Drawing.Point(143, 127);
            this.cbCoverValue.Name = "cbCoverValue";
            this.cbCoverValue.Size = new System.Drawing.Size(241, 26);
            this.cbCoverValue.TabIndex = 47;
            // 
            // btnInsured
            // 
            this.btnInsured.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(108)))), ((int)(((byte)(104)))));
            this.btnInsured.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.btnInsured.ForeColor = System.Drawing.Color.White;
            this.btnInsured.Location = new System.Drawing.Point(203, 341);
            this.btnInsured.Name = "btnInsured";
            this.btnInsured.Size = new System.Drawing.Size(117, 29);
            this.btnInsured.TabIndex = 46;
            this.btnInsured.Text = "Insured";
            this.btnInsured.UseVisualStyleBackColor = false;
            this.btnInsured.Click += new System.EventHandler(this.btnInsured_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(46)))), ((int)(((byte)(15)))));
            this.panel1.Location = new System.Drawing.Point(143, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 1);
            this.panel1.TabIndex = 44;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(46)))), ((int)(((byte)(15)))));
            this.panel7.Location = new System.Drawing.Point(143, 190);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 1);
            this.panel7.TabIndex = 45;
            // 
            // txtPolicyPeriod
            // 
            this.txtPolicyPeriod.BackColor = System.Drawing.Color.White;
            this.txtPolicyPeriod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPolicyPeriod.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.txtPolicyPeriod.Location = new System.Drawing.Point(143, 206);
            this.txtPolicyPeriod.Name = "txtPolicyPeriod";
            this.txtPolicyPeriod.Size = new System.Drawing.Size(240, 24);
            this.txtPolicyPeriod.TabIndex = 42;
            this.txtPolicyPeriod.TextChanged += new System.EventHandler(this.txtPolicyPeriod_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.txtProductName.Location = new System.Drawing.Point(143, 165);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(240, 24);
            this.txtProductName.TabIndex = 43;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblError.Location = new System.Drawing.Point(159, 305);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 50;
            // 
            // InsureProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 407);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCoverValue);
            this.Controls.Add(this.btnInsured);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtPolicyPeriod);
            this.Controls.Add(this.txtProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsureProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InsureProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCoverValue;
        private System.Windows.Forms.Button btnInsured;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtPolicyPeriod;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblError;
    }
}