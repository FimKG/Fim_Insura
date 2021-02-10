
namespace Fim_Insura.user_Control
{
    partial class UC_Rv_Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvProdList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 32.25F);
            this.lblHeader.Location = new System.Drawing.Point(86, 39);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(298, 52);
            this.lblHeader.TabIndex = 58;
            this.lblHeader.Text = "Your Poducts";
            // 
            // dgvProdList
            // 
            this.dgvProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdList.Location = new System.Drawing.Point(17, 111);
            this.dgvProdList.Name = "dgvProdList";
            this.dgvProdList.Size = new System.Drawing.Size(409, 225);
            this.dgvProdList.TabIndex = 60;
            // 
            // UC_Rv_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProdList);
            this.Controls.Add(this.lblHeader);
            this.Name = "UC_Rv_Product";
            this.Size = new System.Drawing.Size(450, 400);
            this.Load += new System.EventHandler(this.UC_Rv_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvProdList;
    }
}
