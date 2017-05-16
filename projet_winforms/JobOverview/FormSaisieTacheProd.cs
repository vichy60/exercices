using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobOverview
{
    public partial class FormSaisieTacheProd : Form

         
    {

        #region propriétés
        public Tache TacheProdSaisie { get; private set; }
        #endregion


        public FormSaisieTacheProd()
        {
            InitializeComponent();
        }


        #region Méthode

        protected override void OnClosing(CancelEventArgs e)

        {
            //if (this.DialogResult == DialogResult.OK)
            //{
            //    TacheProdSaisie = new Tache();
            //    TacheProdSaisie.Nom = tbNom.Text;
            //    TacheProdSaisie.Catégorie = int.Parse(mtbCat.Text);
            //    ///  on test si la catégorieID existe dans la table si ce n'est pas le cas on remplace la valeur par 9 "autre"
            //  //  if(! DAL.GetCat()  /*Contains(ProduitSaisi.Catégorie.ToString()))*/
            //    //{
            //    //    ProduitSaisi.Catégorie = 9;
            //    //}
            //    TacheProdSaisie.QtUnit = tbQtU.Text;
            //    TacheProdSaisie.PrixUnit = decimal.Parse(mtbPrixU.Text);
            //    TacheProdSaisie.Unit = int.Parse(mtbUnitStock.Text);
            //    TacheProdSaisie.FournisseurId = int.Parse(mtbFourn.Text);
            //}








            base.OnClosing(e);
        }

        #endregion





    }
}
