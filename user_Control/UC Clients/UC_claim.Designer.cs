
namespace Fim_Insura.user_Control
{
    partial class UC_claim
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbCoverValue = new System.Windows.Forms.ComboBox();
            this.btnInsured = new System.Windows.Forms.Button();
            this.gvClaim = new System.Windows.Forms.DataGridView();
            this.insura_DBDataSet = new Fim_Insura.Insura_DBDataSet();
            this.insuraDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insura_DBDataSet1 = new Fim_Insura.Insura_DBDataSet1();
            this.productTBsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTBsTableAdapter = new Fim_Insura.Insura_DBDataSet1TableAdapters.ProductTBsTableAdapter();
            this.productTBsTableAdapter1 = new Fim_Insura.Insura_DBDataSetTableAdapters.ProductTBsTableAdapter();
            this.tableAdapterManager = new Fim_Insura.Insura_DBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gvClaim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insura_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuraDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insura_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 32.25F);
            this.label2.Location = new System.Drawing.Point(230, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 52);
            this.label2.TabIndex = 49;
            this.label2.Text = "Claim";
            // 
            // cbCoverValue
            // 
            this.cbCoverValue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productTBsBindingSource, "ProductName", true));
            this.cbCoverValue.DataSource = this.insuraDBDataSetBindingSource;
            this.cbCoverValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCoverValue.Font = new System.Drawing.Font("Verdana", 12F);
            this.cbCoverValue.FormattingEnabled = true;
            this.cbCoverValue.Location = new System.Drawing.Point(134, 127);
            this.cbCoverValue.Name = "cbCoverValue";
            this.cbCoverValue.Size = new System.Drawing.Size(241, 26);
            this.cbCoverValue.TabIndex = 48;
            this.cbCoverValue.SelectedIndexChanged += new System.EventHandler(this.cbCoverValue_SelectedIndexChanged);
            // 
            // btnInsured
            // 
            this.btnInsured.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(108)))), ((int)(((byte)(104)))));
            this.btnInsured.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.btnInsured.ForeColor = System.Drawing.Color.White;
            this.btnInsured.Location = new System.Drawing.Point(176, 339);
            this.btnInsured.Name = "btnInsured";
            this.btnInsured.Size = new System.Drawing.Size(117, 29);
            this.btnInsured.TabIndex = 47;
            this.btnInsured.Text = "Insured";
            this.btnInsured.UseVisualStyleBackColor = false;
            this.btnInsured.Click += new System.EventHandler(this.btnInsured_Click);
            // 
            // gvClaim
            // 
            this.gvClaim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClaim.Location = new System.Drawing.Point(65, 168);
            this.gvClaim.Name = "gvClaim";
            this.gvClaim.RowTemplate.Height = 25;
            this.gvClaim.Size = new System.Drawing.Size(350, 155);
            this.gvClaim.TabIndex = 50;
            // 
            // insura_DBDataSet
            // 
            this.insura_DBDataSet.DataSetName = "Insura_DBDataSet";
            this.insura_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insuraDBDataSetBindingSource
            // 
            this.insuraDBDataSetBindingSource.DataSource = this.insura_DBDataSet;
            this.insuraDBDataSetBindingSource.Position = 0;
            // 
            // insura_DBDataSet1
            // 
            this.insura_DBDataSet1.DataSetName = "Insura_DBDataSet1";
            this.insura_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTBsBindingSource
            // 
            this.productTBsBindingSource.DataMember = "ProductTBs";
            this.productTBsBindingSource.DataSource = this.insura_DBDataSet1;
            // 
            // productTBsTableAdapter
            // 
            this.productTBsTableAdapter.ClearBeforeFill = true;
            // 
            // productTBsTableAdapter1
            // 
            this.productTBsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Fim_Insura.Insura_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UC_claim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvClaim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCoverValue);
            this.Controls.Add(this.btnInsured);
            this.Name = "UC_claim";
            this.Size = new System.Drawing.Size(450, 400);
            this.Load += new System.EventHandler(this.UC_claim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvClaim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insura_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuraDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insura_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCoverValue;
        private System.Windows.Forms.Button btnInsured;
        private System.Windows.Forms.DataGridView gvClaim;
        private System.Windows.Forms.BindingSource productTBsBindingSource;
        private Insura_DBDataSet1 insura_DBDataSet1;
        private Insura_DBDataSet insura_DBDataSet;
        private System.Windows.Forms.BindingSource insuraDBDataSetBindingSource;
        private Insura_DBDataSet1TableAdapters.ProductTBsTableAdapter productTBsTableAdapter;
        private Insura_DBDataSetTableAdapters.ProductTBsTableAdapter productTBsTableAdapter1;
        private Insura_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
