using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class FormSaisieProduit : Form
    {

        #region propriétés
        public Produit ProduitSaisi { get; private set; }
        #endregion

        public FormSaisieProduit()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                ProduitSaisi = new Produit();
                ProduitSaisi.Nom = tbNom.Text;
                ProduitSaisi.Catégorie = int.Parse(mtbCat.Text);
                ///  on test si la catégorieID existe dans la table si ce n'est pas le cas on remplace la valeur par 9 "autre"
              //  if(! DAL.GetCat()  /*Contains(ProduitSaisi.Catégorie.ToString()))*/
                //{
                //    ProduitSaisi.Catégorie = 9;
                //}
                ProduitSaisi.QtUnit = tbQtU.Text;
                ProduitSaisi.PrixUnit = decimal.Parse(mtbPrixU.Text);
                ProduitSaisi.Unit = int.Parse(mtbUnitStock.Text);
                ProduitSaisi.FournisseurId = int.Parse(mtbFourn.Text);
            }


            base.OnClosing(e);
        }

    }
}
