using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ADO
{
    public class Commande
    {
        [XmlAttribute]
        public int CommandeId { get; set; }
        [XmlAttribute]
        public DateTime DateCommande { get; set; }
        [XmlAttribute]
        public DateTime DateLivraion { get; set; }
        [XmlAttribute]
        public int NbProduitsCom { get; set; }
        [XmlAttribute]
        public decimal MontantCom { get; set; }
        [XmlAttribute]
        public decimal Frais { get; set; }
        [XmlAttribute]
        public string CustomerID { get; set; }
        
        public List<LigneCommande> listLigneCom { get; set; }

    }


    public class LigneCommande
    {
        [XmlAttribute]
        public int ProductId { get; set; }
        [XmlAttribute]
        public decimal UnitPrice { get; set; }
        [XmlAttribute]
        public short Quantity { get; set; }
        [XmlAttribute]
        public float Discount { get; set; }



    }


  


}
