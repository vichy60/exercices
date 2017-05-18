using ExempleMVVM.Entités;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace ExempleMVVM.ViewModel
{
    public class VMMenu1 : ViewModelBase
    {
        public ObservableCollection<Donnée> Données { get; }
        public bool SensAscendant { get; set; } = true;

        public VMMenu1()
        {
            Données = new ObservableCollection<Donnée>(Model.DAL.ChargerDonnées());
        }

        private ICommand _cmdTri;
        public ICommand CmdTri
        {
            get
            {
                if (_cmdTri == null)
                    _cmdTri = new RelayCommand(Tri);
                return _cmdTri;
            }
        }

        private void Tri(object obj)
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(Données);
            view.SortDescriptions.Clear();

            ListSortDirection sens = SensAscendant ? ListSortDirection.Ascending : ListSortDirection.Descending;
            view.SortDescriptions.Add(new SortDescription("Nom", sens));
        }
    }
}
