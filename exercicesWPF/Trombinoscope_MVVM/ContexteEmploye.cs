using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Windows.Input;

namespace Trombinoscope2
{
	public class ContexteEmploye : ViewModelBase
    {
		
		public ObservableCollection<Employe> Employes { get; }
		private Employe  _nouvelEmploye; 
		public Employe NouvelEmploye {
			get { return _nouvelEmploye; }
			private set 
			{
                SetProperty(ref _nouvelEmploye,value );
			}
		}


		public ContexteEmploye()
		{
			Employes = new ObservableCollection<Employe>(DAL.GetEmployesTerritoires());
			NouvelEmploye = new Employe();
		}

		private ICommand _cmdAjouter;
		public ICommand CmdAjouter
		{
			get
			{
				if (_cmdAjouter == null)
					_cmdAjouter = new RelayCommand(AjouterEmploye);

				return _cmdAjouter;
			}
		}

		private ICommand _cmdSupprimer;
		public ICommand CmdSupprimer
		{
			get
			{
				if (_cmdSupprimer == null)
					_cmdSupprimer = new RelayCommand(SupprimerEmploye);

				return _cmdSupprimer;
			}
		}

		private void SupprimerEmploye(object obj)
		{
			var emp = (Employe)CollectionViewSource.GetDefaultView(Employes).CurrentItem;
			Employes.Remove(emp);
		}

        //private void AjouterEmploye(object o)
        //{
        //    if (!string.IsNullOrEmpty(NouvelEmploye.Nom) &&
        //        !string.IsNullOrEmpty(NouvelEmploye.Prenom))
        //        Employes.Add(NouvelEmploye);

        //    NouvelEmploye = new Employe();
        //}

        private void AjouterEmploye(object o)
        {
            WndAjoutEmploye dlg = new WndAjoutEmploye(NouvelEmploye);
            bool? res = dlg.ShowDialog();
            if (res.Value)
            {
                Employes.Add(NouvelEmploye);
                NouvelEmploye = new Employe();
            }
        }
    }
}
