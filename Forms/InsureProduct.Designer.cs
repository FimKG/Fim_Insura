
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
            this.cbCoverValue = new System.Windows.Forms.ComboBox();
            this.btnCalculatePolicy = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtPolicyPeriod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCoverValue
            // 
            this.cbCoverValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCoverValue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCoverValue.FormattingEnabled = true;
            this.cbCoverValue.Items.AddRange(new object[] {
            "Select Cover Value",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000"});
            this.cbCoverValue.Location = new System.Drawing.Point(171, 121);
            this.cbCoverValue.Name = "cbCoverValue";
            this.cbCoverValue.Size = new System.Drawing.Size(281, 26);
            this.cbCoverValue.TabIndex = 34;
            // 
            // btnCalculatePolicy
            // 
            this.btnCalculatePolicy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(108)))), ((int)(((byte)(104)))));
            this.btnCalculatePolicy.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculatePolicy.ForeColor = System.Drawing.Color.White;
            this.btnCalculatePolicy.Location = new System.Drawing.Point(254, 360);
            this.btnCalculatePolicy.Name = "btnCalculatePolicy";
            this.btnCalculatePolicy.Size = new System.Drawing.Size(137, 34);
            this.btnCalculatePolicy.TabIndex = 33;
            this.btnCalculatePolicy.Text = "Calculate";
            this.btnCalculatePolicy.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(46)))), ((int)(((byte)(15)))));
            this.panel7.Location = new System.Drawing.Point(99, 323);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 1);
            this.panel7.TabIndex = 32;
            // 
            // txtPolicyPeriod
            // 
            this.txtPolicyPeriod.BackColor = System.Drawing.Color.White;
            this.txtPolicyPeriod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPolicyPeriod.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPolicyPeriod.Location = new System.Drawing.Point(99, 294);
            this.txtPolicyPeriod.Name = "txtPolicyPeriod";
            this.txtPolicyPeriod.PlaceholderText = "Policy Period";
            this.txtPolicyPeriod.Size = new System.Drawing.Size(280, 24);
            this.txtPolicyPeriod.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(99, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 52);
            this.label2.TabIndex = 35;
            this.label2.Text = "Insure Your Product";
            // 
            // InsureProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCoverValue);
            this.Controls.Add(this.btnCalculatePolicy);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtPolicyPeriod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsureProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InsureProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCoverValue;
        private System.Windows.Forms.Button btnCalculatePolicy;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtPolicyPeriod;
        private System.Windows.Forms.Label label2;
    }
}