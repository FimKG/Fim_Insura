
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
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvProdList = new System.Windows.Forms.DataGridView();
            this.insura_DBDataSet = new Fim_Insura.Insura_DBDataSet();
            this.productTBsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTBsTableAdapter = new Fim_Insura.Insura_DBDataSetTableAdapters.ProductTBsTableAdapter();
            this.coverValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiumPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insura_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBsBindingSource)).BeginInit();
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
            this.dgvProdList.AutoGenerateColumns = false;
            this.dgvProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coverValueDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.premiumPriceDataGridViewTextBoxColumn});
            this.dgvProdList.DataSource = this.productTBsBindingSource;
            this.dgvProdList.Location = new System.Drawing.Point(17, 111);
            this.dgvProdList.Name = "dgvProdList";
            this.dgvProdList.Size = new System.Drawing.Size(409, 225);
            this.dgvProdList.TabIndex = 60;
            // 
            // insura_DBDataSet
            // 
            this.insura_DBDataSet.DataSetName = "Insura_DBDataSet";
            this.insura_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTBsBindingSource
            // 
            this.productTBsBindingSource.DataMember = "ProductTBs";
            this.productTBsBindingSource.DataSource = this.insura_DBDataSet;
            // 
            // productTBsTableAdapter
            // 
            this.productTBsTableAdapter.ClearBeforeFill = true;
            // 
            // coverValueDataGridViewTextBoxColumn
            // 
            this.coverValueDataGridViewTextBoxColumn.DataPropertyName = "CoverValue";
            this.coverValueDataGridViewTextBoxColumn.HeaderText = "CoverValue";
            this.coverValueDataGridViewTextBoxColumn.Name = "coverValueDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // premiumPriceDataGridViewTextBoxColumn
            // 
            this.premiumPriceDataGridViewTextBoxColumn.DataPropertyName = "PremiumPrice";
            this.premiumPriceDataGridViewTextBoxColumn.HeaderText = "PremiumPrice";
            this.premiumPriceDataGridViewTextBoxColumn.Name = "premiumPriceDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.insura_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvProdList;
        private System.Windows.Forms.DataGridViewTextBoxColumn coverValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premiumPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productTBsBindingSource;
        private Insura_DBDataSet insura_DBDataSet;
        private Insura_DBDataSetTableAdapters.ProductTBsTableAdapter productTBsTableAdapter;
    }
}
