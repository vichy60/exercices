namespace ADO
{
    partial class FormListeCommandes
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
            this.dgvCommandes = new System.Windows.Forms.DataGridView();
            this.dgvListCommandes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCherche = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.btExportWriter = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommandes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommandes
            // 
            this.dgvCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandes.Location = new System.Drawing.Point(12, 132);
            this.dgvCommandes.Name = "dgvCommandes";
            this.dgvCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommandes.Size = new System.Drawing.Size(360, 294);
            this.dgvCommandes.TabIndex = 0;
            // 
            // dgvListCommandes
            // 
            this.dgvListCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCommandes.Location = new System.Drawing.Point(392, 132);
            this.dgvListCommandes.Name = "dgvListCommandes";
            this.dgvListCommandes.Size = new System.Drawing.Size(488, 294);
            this.dgvListCommandes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Commandes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "lignes de commandes";
            // 
            // tbCherche
            // 
            this.tbCherche.Location = new System.Drawing.Point(19, 43);
            this.tbCherche.Name = "tbCherche";
            this.tbCherche.Size = new System.Drawing.Size(100, 20);
            this.tbCherche.TabIndex = 4;
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(139, 42);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(90, 30);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "Cherche";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btExport
            // 
            this.btExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExport.Location = new System.Drawing.Point(718, 49);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(112, 23);
            this.btExport.TabIndex = 6;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            // 
            // btExportWriter
            // 
            this.btExportWriter.Location = new System.Drawing.Point(836, 50);
            this.btExportWriter.Name = "btExportWriter";
            this.btExportWriter.Size = new System.Drawing.Size(110, 23);
            this.btExportWriter.TabIndex = 7;
            this.btExportWriter.Text = "ExportWriter";
            this.btExportWriter.UseVisualStyleBackColor = true;
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(724, 95);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(75, 23);
            this.btImport.TabIndex = 8;
            this.btImport.Text = "IMPORT";
            this.btImport.UseVisualStyleBackColor = true;
            // 
            // FormListeCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 468);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btExportWriter);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbCherche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListCommandes);
            this.Controls.Add(this.dgvCommandes);
            this.Name = "FormListeCommandes";
            this.Text = "FormListeCommandes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommandes;
        private System.Windows.Forms.DataGridView dgvListCommandes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCherche;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btExportWriter;
        private System.Windows.Forms.Button btImport;
    }
}