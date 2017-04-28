namespace ADO
{
    partial class FormFournisseurs
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
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.cbbPays = new System.Windows.Forms.ComboBox();
            this.lbNbProduit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(26, 94);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(847, 193);
            this.dgvSupplier.TabIndex = 0;
            // 
            // cbbPays
            // 
            this.cbbPays.FormattingEnabled = true;
            this.cbbPays.Location = new System.Drawing.Point(33, 26);
            this.cbbPays.Name = "cbbPays";
            this.cbbPays.Size = new System.Drawing.Size(194, 21);
            this.cbbPays.TabIndex = 1;
            
            // 
            // lbNbProduit
            // 
            this.lbNbProduit.AutoSize = true;
            this.lbNbProduit.Location = new System.Drawing.Point(30, 54);
            this.lbNbProduit.Name = "lbNbProduit";
            this.lbNbProduit.Size = new System.Drawing.Size(35, 13);
            this.lbNbProduit.TabIndex = 2;
            this.lbNbProduit.Text = "label1";
            // 
            // FormFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 462);
            this.Controls.Add(this.lbNbProduit);
            this.Controls.Add(this.cbbPays);
            this.Controls.Add(this.dgvSupplier);
            this.Name = "FormFournisseurs";
            this.Text = "FormFournisseurs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.ComboBox cbbPays;
        private System.Windows.Forms.Label lbNbProduit;
    }
}