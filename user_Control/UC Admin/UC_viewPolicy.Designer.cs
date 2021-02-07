
namespace Fim_Insura.user_Control.UC_Admin
{
    partial class UC_viewPolicy
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
            this.gvProdList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvProdList
            // 
            this.gvProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProdList.Location = new System.Drawing.Point(53, 140);
            this.gvProdList.Name = "gvProdList";
            this.gvProdList.RowTemplate.Height = 25;
            this.gvProdList.Size = new System.Drawing.Size(477, 201);
            this.gvProdList.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 32.25F);
            this.label2.Location = new System.Drawing.Point(158, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 52);
            this.label2.TabIndex = 60;
            this.label2.Text = "Policies";
            // 
            // UC_viewPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvProdList);
            this.Controls.Add(this.label2);
            this.Name = "UC_viewPolicy";
            this.Size = new System.Drawing.Size(583, 404);
            ((System.ComponentModel.ISupportInitialize)(this.gvProdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvProdList;
        private System.Windows.Forms.Label label2;
    }
}
