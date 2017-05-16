namespace JobOverview
{
    partial class FormSaisieTacheProd
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
            this.btOK = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(74, 376);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 0;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btAnnuler
            // 
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(201, 376);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 1;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormSaisieTacheProd
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAnnuler;
            this.ClientSize = new System.Drawing.Size(640, 431);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btOK);
            this.Name = "FormSaisieTacheProd";
            this.Text = "FormSaisieTacheProd";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btAnnuler;
    }
}