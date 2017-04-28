using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class Produit
    {
        #region propriétés
        public int Id { get; set; }
        public string Nom { get; set; }
        public int? Catégorie { get; set; }
        public string QtUnit { get; set; }
        public decimal? PrixUnit { get; set; }
        public int? Unit { get; set; }
        public int? FournisseurId { get; set; }


        #endregion



    }
}
