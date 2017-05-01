namespace ADO
{
    partial class FormProduits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduits));
            this.btAjou = new System.Windows.Forms.Button();
            this.btSup = new System.Windows.Forms.Button();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.btRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // btAjou
            // 
            resources.ApplyResources(this.btAjou, "btAjou");
            this.btAjou.Name = "btAjou";
            this.btAjou.UseVisualStyleBackColor = true;
            // 
            // btSup
            // 
            resources.ApplyResources(this.btSup, "btSup");
            this.btSup.Name = "btSup";
            this.btSup.UseVisualStyleBackColor = true;
            // 
            // dgvProduits
            // 
            resources.ApplyResources(this.dgvProduits, "dgvProduits");
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Name = "dgvProduits";
            // 
            // btRecord
            // 
            resources.ApplyResources(this.btRecord, "btRecord");
            this.btRecord.Name = "btRecord";
            this.btRecord.UseVisualStyleBackColor = true;
            // 
            // FormProduits
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btRecord);
            this.Controls.Add(this.dgvProduits);
            this.Controls.Add(this.btSup);
            this.Controls.Add(this.btAjou);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::ADO.Properties.Settings.Default, "positionFormProduit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::ADO.Properties.Settings.Default.positionFormProduit;
            this.Name = "FormProduits";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAjou;
        private System.Windows.Forms.Button btSup;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.Button btRecord;
    }
}