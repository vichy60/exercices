using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExplorateurFichiers;
using System.IO;

namespace Winforms_exercices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAnalyser.Click += BtnAnalyser_Click;
            btnfolder.Click += Btnfolder_Click;
            chkTotFichier.CheckedChanged += ChkTotFichier_CheckedChanged;

            //exemple utilisation expression lambda à la place d'une méthode
            //chkFichCs.CheckedChanged += ChkFichCs_CheckedChanged;
            chkFichCs.CheckedChanged += (object sender, EventArgs e) => { lbFichCs.Visible = chkFichCs.Checked; };

            chkFichLong.CheckedChanged += ChkFichLong_CheckedChanged;
 
            chkFichProj.CheckedChanged += ChkFichProj_CheckedChanged;
            this.FormClosed += Form1_FormClosing;
            this.Load += Form1_Load;


        }

        private void BtnAnalyser_Click(object sender, EventArgs e)
        {

            if (Directory.Exists(tbFolder.Text))
            {
                Analyseur analyse = new Analyseur();
                analyse.AnalyserDossier(tbFolder.Text);



                lbFichCs.Text = string.Format("{0} Fichiers cs", analyse.fichierCs);
                lbTotFichier.Text = string.Format("{0} Fichiers au total", analyse.fichierTotal);
                lbValFichLon.Text = analyse.fichierLong;
                listBFich.Items.Clear();
                foreach (var item in analyse.listFichierProjet)
                {
                    listBFich.Items.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbFolder.Text = Properties.Settings.Default.CheminDossier;
        }

        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
           
            var result = MessageBox.Show(Properties.Resources.  , , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //control du resultat
            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.nbTotFi = chkTotFichier.Checked;
                Properties.Settings.Default.nbFichCs = chkFichCs.Checked;
                Properties.Settings.Default.NbFichLon = chkFichLong.Checked;
                Properties.Settings.Default.ListFichPro = chkFichProj.Checked;
                Properties.Settings.Default.CheminDossier = tbFolder.Text;
                Properties.Settings.Default.Save();
            }
            
        }

        private void ChkFichLong_CheckedChanged(object sender, EventArgs e)
        {
            lbFichLon.Visible = chkFichLong.Checked;
            lbValFichLon.Visible = chkFichLong.Checked;
        }

        private void ChkFichProj_CheckedChanged(object sender, EventArgs e)
        {
            listBFich.Visible = chkFichProj.Checked;
               


        }

        //exemple utilisation expression lambda à la place d'une méthode (voir ci dessus!!)
        //private void ChkFichCs_CheckedChanged(object sender, EventArgs e)
        //{

        //    lbFichCs.Visible = chkFichCs.Checked;

        //}

        private void ChkTotFichier_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTotFichier.Checked == true)
            {
                lbTotFichier.Visible = true;
            }
            else
                        lbTotFichier.Visible = false;

        }

        private void Btnfolder_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderdiag = new FolderBrowserDialog();
            DialogResult res=folderdiag.ShowDialog();
            //MessageBox.Show("fermer");
                   

                tbFolder.Text = folderdiag.SelectedPath;
            
        }

      
    }
}
