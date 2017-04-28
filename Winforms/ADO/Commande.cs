using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class Commande
    {

        public int CommandeId { get; set; }
        public DateTime DateCommande { get; set; }
        public DateTime DateLivraion { get; set; }
        public int NbProduitsCom { get; set; }
        public decimal MontantCom { get; set; }
        public decimal Frais { get; set; }

    }


  


}
