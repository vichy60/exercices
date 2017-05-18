using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Saisie_de_taches
{
    public enum ModesEdition { Consultation, Edition}
    public class Contexte : ViewModelBase
    {
        private ModesEdition _modeEdit;
        #region Propriétés
        public List<Tache> Taches { get; private set; }

        public ModesEdition ModeEdit
        {
            get { return _modeEdit; }
            set { SetProperty(ref _modeEdit, value); }
        }

        #endregion

        #region Constructeurs
        public Contexte()
        {
            Taches = AccesDonnees.ChargerTaches(); 
        }
        #endregion

        #region COMMANDE
        /////// Commande Ajouter///////////////////////////////////////////
        private ICommand _cmdAjouter;
        public ICommand CmdAjouter
        {
            get
            {
                if (_cmdAjouter == null)
                    _cmdAjouter = new RelayCommand(AjouterTache,ActiverBouton);

                return _cmdAjouter;
            }
        }


        /////// Commande Supprimer//////////////////////////////////////////
        private ICommand _cmdSupprimer;
        public ICommand CmdSupprimer
        {
            get
            {
                if (_cmdSupprimer == null)
                    _cmdSupprimer = new RelayCommand(SupprimerTache, ActiverBouton);

                return _cmdSupprimer;
            }
        }
        /////// Commande Enregistrer////////////////////////////////////////////
        private ICommand _cmdEnregistrer;
        public ICommand CmdEnregistrer
        {
            get
            {
                if (_cmdEnregistrer == null)
                    _cmdEnregistrer = new RelayCommand(EnregistrerTache, DesactiverBouton);

                return _cmdEnregistrer;
            }
        }
        ///////// Commande Annuler///////////////////////////////////////////////
        private ICommand _cmdAnnuler;
        public ICommand CmdAnnuler
        {
            get
            {
                if (_cmdAnnuler == null)
                    _cmdAnnuler = new RelayCommand(AnnulerTache, DesactiverBouton);

                return _cmdAnnuler;
            }
        }



        #endregion
        #region Méthodes Privées

        private void AjouterTache(object operateur)
        {
            ModeEdit = ModesEdition.Edition;
        }
        private void SupprimerTache(object operateur)
        {
            ModeEdit = ModesEdition.Edition;
        }
        private void EnregistrerTache(object operateur)
        {
            ModeEdit = ModesEdition.Consultation;
        }
        private void AnnulerTache(object operateur)
        {
            ModeEdit = ModesEdition.Consultation;
        }
        private bool ActiverBouton(object obj)
        {
            return ModeEdit == ModesEdition.Consultation;
        }
        private bool DesactiverBouton(object obj)
        {
            return ModeEdit == ModesEdition.Edition;
        }
        #endregion
    }
}
