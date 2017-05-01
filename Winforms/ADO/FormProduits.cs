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
    public partial class FormProduits : Form
    {

        private BindingList<Produit> _list;
        private List<Produit> _produitsAjoutés;
        private List<Produit> _produitsSupprimé;
        public FormProduits()
        {
            InitializeComponent();
            btAjou.Click += BtAjou_Click;
            btSup.Click += BtSup_Click;
            btRecord.Click += BtRecord_Click;


        }

        private void BtRecord_Click(object sender, EventArgs e)

        {
            DAL.SuppEnMasse(_produitsSupprimé);
            DAL.AjouEnMasse(_produitsAjoutés);
            _list = DAL.GetProd();

            dgvProduits.DataSource = _list;

        }

        private void BtSup_Click(object sender, EventArgs e)
        {
            //todo mettre ici le try catch (le produit sélectionné est référencé par une ligne de commande)
            //if (DAL.SupProd((Produit)dgvProduits.CurrentRow.DataBoundItem)) -------mis en commentaire pour faire l'exercice 4.1
            _produitsSupprimé.Add((Produit)dgvProduits.CurrentRow.DataBoundItem);
            _list.Remove((Produit)dgvProduits.CurrentRow.DataBoundItem);




        }

        private void BtAjou_Click(object sender, EventArgs e)
        {

            using (FormSaisieProduit formsaisieproduit = new FormSaisieProduit())
            {
                DialogResult dialog = formsaisieproduit.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    _list.Add(formsaisieproduit.ProduitSaisi);
                }
                //DAL.AjouProd(formsaisieproduit.ProduitSaisi);-------mis en commentaire pour faire l'exercice 4.1
                _produitsAjoutés.Add(formsaisieproduit.ProduitSaisi);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            _produitsSupprimé = new List<Produit>();       
            _produitsAjoutés = new List<Produit>();
            _list = DAL.GetProd();

            dgvProduits.DataSource = _list;

            base.OnLoad(e);
        }

    }
}
