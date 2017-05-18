using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Language = System.Windows.Markup.XmlLanguage.GetLanguage(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
            _dalMeteo = new DALMeteo();
            bt_path.Click += Bt_path_Click;
            cbVue.SelectionChanged += CbVue_SelectionChanged;
            cbTri.SelectionChanged += CbTri_SelectionChanged;
            cbTriSens.SelectionChanged += CbTriSens_SelectionChanged;
        }

        private void CbTriSens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Tri();
        }

        private void CbTri_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Applique le tri à la collection d'achats
            //ICollectionView view = CollectionViewSource.GetDefaultView(_dalMeteo.Data);
            //view.SortDescriptions.Clear();
            //var sens = cbTriSens.SelectedIndex == 0 ? ListSortDirection.Ascending :
            //                                          ListSortDirection.Descending;
            //var tri = new SortDescription(cbTri.SelectedValue.ToString(), sens);
            //view.SortDescriptions.Add(tri);
            this.Tri();

        }

        private void CbVue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ICollectionView view = CollectionViewSource.GetDefaultView(_dalMeteo.Data);
            //view.SortDescriptions.Clear();
            //view.GroupDescriptions.Clear();

            //if (cbVue.SelectedValue.ToString() == "Vignettes")
            //{
            //    lb_Données.ItemTemplate = (DataTemplate)this.Resources["Template_vignette"];
            //    gdStatsVignette.Visibility = Visibility.Visible;
            //    gdStatsGroupe.Visibility = Visibility.Hidden;
            //}
            //else
            //{
            //    view.SortDescriptions.Add(new SortDescription("Date", ListSortDirection.Ascending));

            //    view.GroupDescriptions.Add(new PropertyGroupDescription("Année"));
            //    lb_Données.ItemTemplate = (DataTemplate)this.Resources["Template_groupe"];
            //    gdStatsVignette.Visibility = Visibility.Hidden;
            //    gdStatsGroupe.Visibility = Visibility.Visible;
            //}
            this.Tri();
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
        private void Tri()
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(_dalMeteo.Data);
            view.SortDescriptions.Clear();
            view.GroupDescriptions.Clear();
            var sens = cbTriSens.SelectedIndex == 0 ? ListSortDirection.Ascending :
                                                  ListSortDirection.Descending;
            var tri = new SortDescription(cbTri.SelectedValue.ToString(), sens);
            view.SortDescriptions.Add(tri);

            if (cbVue.SelectedValue.ToString() == "Vignettes")
            {
                lb_Données.ItemTemplate = (DataTemplate)this.Resources["Template_vignette"];
                gdStatsVignette.Visibility = Visibility.Visible;
                gdStatsGroupe.Visibility = Visibility.Hidden;


            }
            else
            {
                view.SortDescriptions.Add(new SortDescription("Date", ListSortDirection.Ascending));
                view.GroupDescriptions.Add(new PropertyGroupDescription("Année"));
                lb_Données.ItemTemplate = (DataTemplate)this.Resources["Template_groupe"];
                gdStatsVignette.Visibility = Visibility.Hidden;
                gdStatsGroupe.Visibility = Visibility.Visible;

            }

        }
    }
}
