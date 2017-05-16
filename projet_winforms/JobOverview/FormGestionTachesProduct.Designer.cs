namespace JobOverview
{
    partial class FormGestionTachesProduct
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
            this.btAjouTache = new System.Windows.Forms.Button();
            this.cbPers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTacheProd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacheProd)).BeginInit();
            this.SuspendLayout();
            // 
            // btAjouTache
            // 
            this.btAjouTache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouTache.Location = new System.Drawing.Point(47, 424);
            this.btAjouTache.Name = "btAjouTache";
            this.btAjouTache.Size = new System.Drawing.Size(150, 29);
            this.btAjouTache.TabIndex = 0;
            this.btAjouTache.Text = "Nouvelle Tache";
            this.btAjouTache.UseVisualStyleBackColor = true;
            // 
            // cbPers
            // 
            this.cbPers.FormattingEnabled = true;
            this.cbPers.Location = new System.Drawing.Point(37, 41);
            this.cbPers.Name = "cbPers";
            this.cbPers.Size = new System.Drawing.Size(121, 21);
            this.cbPers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // dgvTacheProd
            // 
            this.dgvTacheProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacheProd.Location = new System.Drawing.Point(38, 87);
            this.dgvTacheProd.Name = "dgvTacheProd";
            this.dgvTacheProd.Size = new System.Drawing.Size(824, 321);
            this.dgvTacheProd.TabIndex = 3;
            // 
            // FormGestionTachesProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 481);
            this.Controls.Add(this.dgvTacheProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPers);
            this.Controls.Add(this.btAjouTache);
            this.Name = "FormGestionTachesProduct";
            this.Text = "FormGestionTachesProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacheProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAjouTache;
        private System.Windows.Forms.ComboBox cbPers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTacheProd;
    }
}