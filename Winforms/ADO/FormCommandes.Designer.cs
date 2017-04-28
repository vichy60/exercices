namespace ADO
{
    partial class FormCommandes
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
            this.dgvCom = new System.Windows.Forms.DataGridView();
            this.btVoirCom = new System.Windows.Forms.Button();
            this.tbComId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCom
            // 
            this.dgvCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCom.Location = new System.Drawing.Point(35, 169);
            this.dgvCom.Name = "dgvCom";
            this.dgvCom.Size = new System.Drawing.Size(658, 231);
            this.dgvCom.TabIndex = 0;
            // 
            // btVoirCom
            // 
            this.btVoirCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoirCom.Location = new System.Drawing.Point(390, 35);
            this.btVoirCom.Name = "btVoirCom";
            this.btVoirCom.Size = new System.Drawing.Size(216, 38);
            this.btVoirCom.TabIndex = 1;
            this.btVoirCom.Text = "Voir les commandes";
            this.btVoirCom.UseVisualStyleBackColor = true;
            // 
            // tbComId
            // 
            this.tbComId.Location = new System.Drawing.Point(58, 53);
            this.tbComId.Name = "tbComId";
            this.tbComId.Size = new System.Drawing.Size(301, 20);
            this.tbComId.TabIndex = 2;
            // 
            // FormCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 426);
            this.Controls.Add(this.tbComId);
            this.Controls.Add(this.btVoirCom);
            this.Controls.Add(this.dgvCom);
            this.Name = "FormCommandes";
            this.Text = "FormCommandes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCom;
        private System.Windows.Forms.Button btVoirCom;
        private System.Windows.Forms.TextBox tbComId;
    }
}