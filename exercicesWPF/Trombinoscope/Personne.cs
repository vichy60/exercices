using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Trombinoscope2
{
    public class Personne
    {
        #region Propriétés
        public int EmployeeId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public ImageSource Photo { get; set; }

        public string NomPrenom { get; set; }

        public List<Territoire> Territoires { get; set; }
        #endregion


    }
}
