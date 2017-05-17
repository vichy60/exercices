using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Collections_de_bandes_dessinées
{
    public class Contexte
    {
        ICollectionView _view;
        #region Propriétés
        public List<CollectionBD> CollectionBD { get; set; }
        #endregion

        #region Constructeurs
        public Contexte()
        {
            CollectionBD = BD_DAL.ChargerCollectionsBD();
            _view = CollectionViewSource.GetDefaultView(CollectionBD);
        }
        #endregion

        #region COMMANDE
        /////// Commande AllerAuPremier///////////////////////////////////////////
        private ICommand _cmdFirst;
        public ICommand CmdFirst
        {
            get
            {
                if (_cmdFirst == null)
                    _cmdFirst = new RelayCommand(AllerAuPremier);

                return _cmdFirst;
            }
        }
        ///////// Commande AllerAuDernier//////////////////////////////////////////
        //private ICommand _cmdLast;
        //public ICommand CmdLast
        //{
        //    get
        //    {
        //        if (_cmdLast == null)
        //            _cmdLast = new RelayCommand(AllerAuDernier);

        //        return _cmdLast;
        //    }
        //}
        ///////// Commande Suivant////////////////////////////////////////////
        //private ICommand _cmdSuivant;
        //public ICommand CmdSuivant
        //{
        //    get
        //    {
        //        if (_cmdSuivant == null)
        //            _cmdSuivant = new RelayCommand(AllerAuSuivant);

        //        return _cmdSuivant;
        //    }
        //}
        /////////// Commande Précédent///////////////////////////////////////////////
        //private ICommand _cmdPrécédent;
        //public ICommand CmdPrécédent
        //{
        //    get
        //    {
        //        if (_cmdPrécédent == null)
        //            _cmdPrécédent = new RelayCommand(AllerAuPrécédent);

        //        return _cmdPrécédent;
        //    }
        //}



        #endregion
        #region Méthodes Privées

        private void AllerAuPremier(object operateur)
        {
            string dir = operateur.ToString();
            // Navigue dans la collection selon la direction souhaitée
            if (dir == "F")
                _view.MoveCurrentToFirst(); // premier élément
            else if (dir == "P" && _view.CurrentPosition > 0)
                _view.MoveCurrentToPrevious(); // élément précédent
            else if (dir == "N" && !_view.IsCurrentAfterLast)
            {
                _view.MoveCurrentToNext(); // élément suivant
                if (_view.IsCurrentAfterLast) _view.MoveCurrentToPrevious();
            }
            else if (dir == "L")
                _view.MoveCurrentToLast(); // dernier élément 
        }
        //private void AllerAuDernier(object operateur)
        //{
        //}
        //private void AllerAuSuivant(object operateur)
        //{
        //}
        //private void AllerAuPrécédent(object operateur)
        //{
        //}
        #endregion
    }
}
