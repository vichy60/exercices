using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace RelevésMétéo
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private MétéoDAL _météoDAL;

		public MainWindow()
		{
			InitializeComponent();
			Language = System.Windows.Markup.XmlLanguage.GetLanguage(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
			_météoDAL = new MétéoDAL();
		}

		private void BtnOuvrirFichier_Click(object sender, RoutedEventArgs e)
		{
			var dlg = new Microsoft.Win32.OpenFileDialog();
			dlg.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;

			if (dlg.ShowDialog() == true)
			{
				// Affichage du chemin du fichier sélectionné
				tbxChemin.Text = dlg.FileName;

				try
				{
					// Chargement des données dans la liste
					_météoDAL.ChargerDonnées(dlg.FileName);

					// Utilisation de l'objet comme contexte de la fenêtre
					DataContext = _météoDAL;
				}
				catch
				{
					MessageBox.Show("Impossible de lire le fichier", "Erreur",
						MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}	
		}

		private void cmbVue_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (_météoDAL == null) return;
			TrierEtGrouper();

			//// Application du template sélectionné
			//lstRelevés.ItemTemplate = (DataTemplate)Resources[cmbVue.SelectedValue];

			//// On efface les regroupements sur la vue par défaut
			//ICollectionView view = CollectionViewSource.GetDefaultView(_météoDAL.Data);
			//view.SortDescriptions.Clear();
			//view.GroupDescriptions.Clear();

			//// Application du regroupement
			//if (cmbVue.SelectedIndex == 1)
			//{
			//	view.SortDescriptions.Add(new SortDescription("Année", ListSortDirection.Ascending));
			//	view.GroupDescriptions.Add(new PropertyGroupDescription("Année"));
			//}
		}

		private void cmbTri_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (_météoDAL == null) return;
			TrierEtGrouper();

			//// On supprime les tris existants
			//ICollectionView view = CollectionViewSource.GetDefaultView(_météoDAL.Data);
			//view.SortDescriptions.Clear();

			//// On récupère le critère et l'ordre de tri
			//string tri = (string)cmbTri.SelectedValue;
			//ListSortDirection ordre = cmbOrdre.SelectedIndex == 0 ? ListSortDirection.Ascending : ListSortDirection.Descending;

			//// Si on demande un tri par mois ou si la vue groupée est sélectionnée,
			//// il faut trier en premier sur l'année
			//if (tri == "Mois" || cmbVue.SelectedIndex == 1)
			//	view.SortDescriptions.Add(new SortDescription("Année", ListSortDirection.Ascending));

			//// On ajoute le tri supplémentaire sélectionné
			//view.SortDescriptions.Add(new SortDescription(tri, ordre));
		}

		// Gestionnaire appelé si on gère un evt commun pour les 3 combos
		private void cmb_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (_météoDAL == null) return;
			TrierEtGrouper();
		}

		private void TrierEtGrouper()
		{
			// Application du template sélectionné
			lstRelevés.ItemTemplate = (DataTemplate)Resources[cmbVue.SelectedValue];

			// On récupère le critère et l'ordre de tri
			string tri = (string)cmbTri.SelectedValue;
			ListSortDirection ordre = cmbOrdre.SelectedIndex == 0 ? ListSortDirection.Ascending : ListSortDirection.Descending;

			ICollectionView view = CollectionViewSource.GetDefaultView(_météoDAL.Data);
			view.SortDescriptions.Clear();

			// Si on demande un tri par mois ou si la vue groupée est sélectionnée,
			// il faut trier en premier sur l'année
			if (tri == "Mois" || cmbVue.SelectedIndex == 1)
				view.SortDescriptions.Add(new SortDescription("Année", ordre));

			// On ajoute le tri supplémentaire sélectionné
			view.SortDescriptions.Add(new SortDescription(tri, ordre));

			// Application du regroupement
			view.GroupDescriptions.Clear();
			if (cmbVue.SelectedIndex == 1)
				view.GroupDescriptions.Add(new PropertyGroupDescription("Année"));
		}
	}
}
