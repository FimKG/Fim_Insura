
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
            this.label2 = new System.Windows.Forms.Label();
            this.gvProdList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(186, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 52);
            this.label2.TabIndex = 58;
            this.label2.Text = "Your Poducts";
            // 
            // gvProdList
            // 
            this.gvProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProdList.Location = new System.Drawing.Point(63, 134);
            this.gvProdList.Name = "gvProdList";
            this.gvProdList.RowTemplate.Height = 25;
            this.gvProdList.Size = new System.Drawing.Size(556, 232);
            this.gvProdList.TabIndex = 59;
            // 
            // UC_Rv_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvProdList);
            this.Controls.Add(this.label2);
            this.Name = "UC_Rv_Product";
            this.Size = new System.Drawing.Size(687, 470);
            ((System.ComponentModel.ISupportInitialize)(this.gvProdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvProdList;
    }
}
