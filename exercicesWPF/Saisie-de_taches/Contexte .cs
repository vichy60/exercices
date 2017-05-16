using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Saisie_de_taches
{
    public class Contexte
    {
        #region Propriétés
        public List<Tache> Taches { get; private set; }
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
                    _cmdAjouter = new RelayCommand(AjouterTache);

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
                    _cmdSupprimer = new RelayCommand(SupprimerTache);

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
                    _cmdEnregistrer = new RelayCommand(EnregistrerTache);

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
                    _cmdAnnuler = new RelayCommand(AnnulerTache);

                return _cmdAnnuler;
            }
        }



        #endregion
        #region Méthodes Privées

        private void AjouterTache(object operateur)
        {
        }
        private void SupprimerTache(object operateur)
        {
        }
        private void EnregistrerTache(object operateur)
        {
        }
        private void AnnulerTache(object operateur)
        {
        }
        #endregion
    }
}
