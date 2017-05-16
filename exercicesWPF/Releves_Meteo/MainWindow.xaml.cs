using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Releves_Meteo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region variables privées
        private DALMeteo _dalMeteo;
        
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            _dalMeteo = new DALMeteo();

            bt_path.Click += Bt_path_Click;

            cbVue.SelectionChanged += CbVue_SelectionChanged;
        }

        private void CbVue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (cbVue.SelectedValue.ToString() == "Vignettes")
            //{
            //    lb_Données.ItemTemplate = (DataTemplate)this.Resources["Template_vignette"];
            //    gdStatsVignette.Visibility = Visibility.Visible;
            //    gdStatsGroupe.Visibility = Visibility.Hidden;
            //}
            //else
            //{
            //    lb_Données.ItemTemplate = (DataTemplate)this.Resources["Template_groupe"];
            //    gdStatsVignette.Visibility = Visibility.Hidden;
            //    gdStatsGroupe.Visibility = Visibility.Visible;
            //}
        }

        private void Bt_path_Click(object sender, RoutedEventArgs e)
        {
            var fenetre_Diag = new OpenFileDialog();//ou Microsoft.Win32.OpenFileDialog si pas de Using!
            fenetre_Diag.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;

            if (fenetre_Diag.ShowDialog() == true)
            {
                try
                {
                    _dalMeteo.ChargerDonnées(fenetre_Diag.FileName);
                    //lb_Données.DataContext = _dalMeteo.Data;
                    //DataContext = _dalMeteo.Stats;
                    DataContext = _dalMeteo;
                }
                catch (Exception)
                {
                    MessageBox.Show("Impossible de charger le fichier!!!!");
                }
            }
        }
    }
}
