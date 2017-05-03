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
    public partial class FormListeCommandes : Form
    {

        private List<Commande> _listCom;

        public FormListeCommandes()
        {
            InitializeComponent();
            dgvCommandes.CellClick += DgvCommandes_CellClick;
            btOK.Click += BtOK_Click;
            btExport.Click += BtExport_Click;
            btImport.Click += BtImport_Click;
            

        }

        private void BtImport_Click(object sender, EventArgs e)
        {
            _listCom = DAL.ImporterXml();
            _listCom = DAL.ImporterXmlLinq();
            ;

        }

        private void BtExport_Click(object sender, EventArgs e)
        {
            DAL.ExportDonneeVersXml(_listCom);
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            string clientId = tbCherche.Text;
            dgvCommandes.DataSource = _listCom.Where(c => c.CustomerID == clientId).ToList();
            int comId;
            comId = ((Commande)dgvCommandes.CurrentRow.DataBoundItem).CommandeId;
            dgvListCommandes.DataSource = _listCom.Where(c => c.CommandeId == comId).FirstOrDefault().listLigneCom;
        }

     

        private void DgvCommandes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int comId;
            comId = ((Commande)dgvCommandes.CurrentRow.DataBoundItem).CommandeId;

            dgvListCommandes.DataSource = _listCom.Where(c => c.CommandeId == comId).FirstOrDefault().listLigneCom;


        }

        protected override void OnLoad(EventArgs e)
        {
            _listCom = DAL.GetComDétail();
            dgvCommandes.DataSource = _listCom;
            #region Paramétrage dgvCommandes
            dgvCommandes.Columns["DateLivraion"].Visible = false;
            dgvCommandes.Columns["NbProduitsCom"].Visible = false;
            dgvCommandes.Columns["MontantCom"].Visible = false;
            dgvCommandes.Columns["Frais"].Visible = false;
            dgvCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCommandes.ReadOnly = true;
            dgvCommandes.Columns["DateCommande"].Resizable = DataGridViewTriState.True;
            #endregion

            DAL.ExporterXml_XmlWriter(_listCom);

            base.OnLoad(e);
        }

       
    }
}
