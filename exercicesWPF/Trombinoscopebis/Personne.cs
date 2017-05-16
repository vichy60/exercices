using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Trombinoscope
{
    public class Personne
    {
        #region Propriétés
        public int EmployeeId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Image Photo { get; set; }

        public string NomPrenom { get; set; }

        #endregion


    }
}
