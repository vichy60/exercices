using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Trombinoscope
{
    public class ContexteEmploye : INotifyPropertyChanged
    {
        #region Propriétés


        private Personne _employeCourant;
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Personne> Employes { get; }
        public Personne EmployeCourant
        {
            get { return _employeCourant; }
            private set
            {
                if (value != _employeCourant)
                {
                    _employeCourant = value;
                    RaisePropertyChanged();
                }

            }
        }

        #endregion

        #region Constructeur
        public ContexteEmploye()
        {
            Employes = new ObservableCollection<Personne>(DAL.GetPersonnes());
            EmployeCourant = new Personne();

        }
        #endregion

        // Commande Ajouter
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


        private void AjouterEmploye(object operateur)
        {
            if (!string.IsNullOrWhiteSpace(EmployeCourant.Nom) && !string.IsNullOrWhiteSpace(EmployeCourant.Prenom))
            {
                Employes.Add(EmployeCourant);
                DAL.InsertPersonne(EmployeCourant);
                EmployeCourant = new Personne();
            }

        }
        
        // Commande suppression

        private ICommand _cmdSupprime;

        public ICommand CmdSupprime
        {
            get
            {
                if (_cmdSupprime == null)
                    _cmdSupprime = new RelayCommand(SupprimerEmploye);

                return _cmdSupprime;
            }
        }
        #region suppression employés

        // suppression dans la liste des employés de l'employé courant
        private void SupprimerEmploye(object operateur)
        {
            var e = (Personne)CollectionViewSource.GetDefaultView(Employes).CurrentItem;
            Employes.Remove(e);

        }

        #endregion

        private void RaisePropertyChanged([CallerMemberName] string prop = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
