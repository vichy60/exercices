using System.Collections.Generic;
using System.Windows.Controls;

namespace Trombinoscope
{
	/// <summary>
	/// Logique d'interaction pour UCCombos.xaml
	/// </summary>
	public partial class UCEmployes : UserControl
	{
		public UCEmployes()
		{
			InitializeComponent();

			DataContext = new ContexteEmploye();
		}

		/*private void LbEmployes_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Employe emp = (Employe)lbEmployes.SelectedItem;
			tblId.Text = emp.Id.ToString();
			tblNom.Text = emp.Nom;
			tblPrenom.Text = emp.Prenom;

			stpEmployeCourant.DataContext = emp;
		}*/
	}
}
