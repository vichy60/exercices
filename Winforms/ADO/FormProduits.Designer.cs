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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btAjou = new System.Windows.Forms.Button();
            this.btSup = new System.Windows.Forms.Button();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.btRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // btAjou
            // 
            this.btAjou.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjou.Location = new System.Drawing.Point(24, 16);
            this.btAjou.Name = "btAjou";
            this.btAjou.Size = new System.Drawing.Size(24, 23);
            this.btAjou.TabIndex = 0;
            this.btAjou.Text = "+";
            this.btAjou.UseVisualStyleBackColor = true;
            // 
            // btSup
            // 
            this.btSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSup.Location = new System.Drawing.Point(70, 16);
            this.btSup.Name = "btSup";
            this.btSup.Size = new System.Drawing.Size(27, 23);
            this.btSup.TabIndex = 1;
            this.btSup.Text = "-";
            this.btSup.UseVisualStyleBackColor = true;
            // 
            // dgvProduits
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduits.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduits.Location = new System.Drawing.Point(13, 52);
            this.dgvProduits.Name = "dgvProduits";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduits.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduits.Size = new System.Drawing.Size(623, 301);
            this.dgvProduits.TabIndex = 2;
            // 
            // btRecord
            // 
            this.btRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecord.Location = new System.Drawing.Point(124, 16);
            this.btRecord.Name = "btRecord";
            this.btRecord.Size = new System.Drawing.Size(142, 23);
            this.btRecord.TabIndex = 3;
            this.btRecord.Text = "Enregistrer";
            this.btRecord.UseVisualStyleBackColor = true;
            // 
            // FormProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 365);
            this.Controls.Add(this.btRecord);
            this.Controls.Add(this.dgvProduits);
            this.Controls.Add(this.btSup);
            this.Controls.Add(this.btAjou);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormProduits";
            this.Text = "FormProduits";
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