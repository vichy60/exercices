namespace ADO
{
    partial class FormSaisieProduit
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
            this.Nom = new System.Windows.Forms.Label();
            this.Catégorie = new System.Windows.Forms.Label();
            this.Quantité_unitaire = new System.Windows.Forms.Label();
            this.Prix_unitaire = new System.Windows.Forms.Label();
            this.Unités_en_stock = new System.Windows.Forms.Label();
            this.Fournisseur = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.mtbCat = new System.Windows.Forms.MaskedTextBox();
            this.mtbPrixU = new System.Windows.Forms.MaskedTextBox();
            this.mtbUnitStock = new System.Windows.Forms.MaskedTextBox();
            this.mtbFourn = new System.Windows.Forms.MaskedTextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.tbQtU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(23, 30);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // Catégorie
            // 
            this.Catégorie.AutoSize = true;
            this.Catégorie.Location = new System.Drawing.Point(23, 67);
            this.Catégorie.Name = "Catégorie";
            this.Catégorie.Size = new System.Drawing.Size(52, 13);
            this.Catégorie.TabIndex = 1;
            this.Catégorie.Text = "Catégorie";
            // 
            // Quantité_unitaire
            // 
            this.Quantité_unitaire.AutoSize = true;
            this.Quantité_unitaire.Location = new System.Drawing.Point(23, 100);
            this.Quantité_unitaire.Name = "Quantité_unitaire";
            this.Quantité_unitaire.Size = new System.Drawing.Size(84, 13);
            this.Quantité_unitaire.TabIndex = 2;
            this.Quantité_unitaire.Text = "Quantité unitaire";
            // 
            // Prix_unitaire
            // 
            this.Prix_unitaire.AutoSize = true;
            this.Prix_unitaire.Location = new System.Drawing.Point(23, 133);
            this.Prix_unitaire.Name = "Prix_unitaire";
            this.Prix_unitaire.Size = new System.Drawing.Size(61, 13);
            this.Prix_unitaire.TabIndex = 3;
            this.Prix_unitaire.Text = "Prix unitaire";
            // 
            // Unités_en_stock
            // 
            this.Unités_en_stock.AutoSize = true;
            this.Unités_en_stock.Location = new System.Drawing.Point(23, 165);
            this.Unités_en_stock.Name = "Unités_en_stock";
            this.Unités_en_stock.Size = new System.Drawing.Size(81, 13);
            this.Unités_en_stock.TabIndex = 4;
            this.Unités_en_stock.Text = "Unités en stock";
            // 
            // Fournisseur
            // 
            this.Fournisseur.AutoSize = true;
            this.Fournisseur.Location = new System.Drawing.Point(23, 207);
            this.Fournisseur.Name = "Fournisseur";
            this.Fournisseur.Size = new System.Drawing.Size(61, 13);
            this.Fournisseur.TabIndex = 5;
            this.Fournisseur.Text = "Fournisseur";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(84, 27);
            this.tbNom.MaxLength = 40;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(353, 20);
            this.tbNom.TabIndex = 1;
            // 
            // mtbCat
            // 
            this.mtbCat.Location = new System.Drawing.Point(120, 60);
            this.mtbCat.Mask = "999";
            this.mtbCat.Name = "mtbCat";
            this.mtbCat.Size = new System.Drawing.Size(100, 20);
            this.mtbCat.TabIndex = 2;
            // 
            // mtbPrixU
            // 
            this.mtbPrixU.Location = new System.Drawing.Point(120, 133);
            this.mtbPrixU.Mask = "99.99";
            this.mtbPrixU.Name = "mtbPrixU";
            this.mtbPrixU.Size = new System.Drawing.Size(100, 20);
            this.mtbPrixU.TabIndex = 4;
            // 
            // mtbUnitStock
            // 
            this.mtbUnitStock.Location = new System.Drawing.Point(120, 165);
            this.mtbUnitStock.Name = "mtbUnitStock";
            this.mtbUnitStock.Size = new System.Drawing.Size(100, 20);
            this.mtbUnitStock.TabIndex = 5;
            // 
            // mtbFourn
            // 
            this.mtbFourn.Location = new System.Drawing.Point(120, 200);
            this.mtbFourn.Name = "mtbFourn";
            this.mtbFourn.Size = new System.Drawing.Size(100, 20);
            this.mtbFourn.TabIndex = 6;
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(289, 245);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 7;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btAnnuler
            // 
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(426, 245);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 8;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // tbQtU
            // 
            this.tbQtU.Location = new System.Drawing.Point(123, 97);
            this.tbQtU.Name = "tbQtU";
            this.tbQtU.Size = new System.Drawing.Size(100, 20);
            this.tbQtU.TabIndex = 3;
            // 
            // FormSaisieProduit
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAnnuler;
            this.ClientSize = new System.Drawing.Size(526, 280);
            this.ControlBox = false;
            this.Controls.Add(this.tbQtU);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.mtbFourn);
            this.Controls.Add(this.mtbUnitStock);
            this.Controls.Add(this.mtbPrixU);
            this.Controls.Add(this.mtbCat);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.Fournisseur);
            this.Controls.Add(this.Unités_en_stock);
            this.Controls.Add(this.Prix_unitaire);
            this.Controls.Add(this.Quantité_unitaire);
            this.Controls.Add(this.Catégorie);
            this.Controls.Add(this.Nom);
            this.Name = "FormSaisieProduit";
            this.Text = "Saisie d\'un produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Catégorie;
        private System.Windows.Forms.Label Quantité_unitaire;
        private System.Windows.Forms.Label Prix_unitaire;
        private System.Windows.Forms.Label Unités_en_stock;
        private System.Windows.Forms.Label Fournisseur;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.MaskedTextBox mtbCat;
        private System.Windows.Forms.MaskedTextBox mtbPrixU;
        private System.Windows.Forms.MaskedTextBox mtbUnitStock;
        private System.Windows.Forms.MaskedTextBox mtbFourn;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.TextBox tbQtU;
    }
}