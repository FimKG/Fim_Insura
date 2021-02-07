
namespace Fim_Insura.user_Control.UC_Admin
{
    partial class UC_viewClients
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
            this.gvClientList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvClientList
            // 
            this.gvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClientList.Location = new System.Drawing.Point(53, 140);
            this.gvClientList.Name = "gvClientList";
            this.gvClientList.RowTemplate.Height = 25;
            this.gvClientList.Size = new System.Drawing.Size(477, 201);
            this.gvClientList.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 32.25F);
            this.label2.Location = new System.Drawing.Point(158, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 52);
            this.label2.TabIndex = 60;
            this.label2.Text = "Clients";
            // 
            // UC_viewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvClientList);
            this.Controls.Add(this.label2);
            this.Name = "UC_viewClients";
            this.Size = new System.Drawing.Size(583, 404);
            ((System.ComponentModel.ISupportInitialize)(this.gvClientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvClientList;
        private System.Windows.Forms.Label label2;
    }
}
