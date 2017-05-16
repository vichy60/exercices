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
    public partial class FormGestionTachesProduct : Form
    {

        #region variables privées

        private BindingList<Tache> _listTachprod;
        private BindingList<Tache> _listTach;
        #endregion




        public FormGestionTachesProduct()
        {
            InitializeComponent();
            btAjouTache.Click += BtAjouTache_Click;
        }

        private void BtAjouTache_Click(object sender, EventArgs e)
        {
            using (FormSaisieTacheProd formSaisieTacheProd = new FormSaisieTacheProd())
            {
                DialogResult dialog = formSaisieTacheProd.ShowDialog();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            cbPers.DataSource = DALTache.GetPers().Select(a => a.Login).ToList();
            _listTach = DALTache.GetTache();

            foreach (var t in _listTach.Where(t => t.Annexe == false))
                _listTachprod.Add(t);

            dgvTacheProd.DataSource = _listTachprod;


            base.OnLoad(e);
        }

        //todo ajouter une tache de production

        //private void BtAjouTache_Click(object sender, EventArgs e)
        //{
        //    using (FormSaisieTacheProd formSaisieTacheProd = new FormSaisieTacheProd())
        //    {
        //        DialogResult dialog = formSaisieTacheProd.ShowDialog();
        //        if (dialog == DialogResult.OK)
        //        {
        //            //_list.Add(formSaisieTacheProd.TacheProdSaisie);
        //        }
        //        //DAL.AjouProd(formsaisieproduit.ProduitSaisi);
        //        //_produitsAjoutés.Add(formsaisieproduit.ProduitSaisi);
        //    }
        //}
    }
}
