using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boites
{



  public  class Program
    {
        static void Main(string[] args)
        {

            Etiquette etqDest = new Etiquette
            {
                Couleur = TypeCouleurs.blanc,
                Format = TypeFormat.L,
                Texte = "Adresse"
            };

            Etiquette etqFragile = new Etiquette
            {
                Couleur = TypeCouleurs.rouge,
                Format = TypeFormat.S,
                Texte = "FRAGILE"
            };

            Boite b1 = new Boite(30.0m,60.0m,20.0m);
            //b1.Couleurs = TypeCouleurs.rouge;
            Console.WriteLine("Boite de volume {0} cm3, de couleur {1} et en {2}",
            b1.Volume, b1.Couleurs, b1.Matière);

            Boite b2 = new Boite(24.0m, 56.0m, 74.0m,TypeMatière.métal);
            Etiquette etq = new boites.Etiquette { Couleur = TypeCouleurs.orange };  //TODO
            Console.WriteLine("Boite de volume {0} cm3, de couleur {1} et en {2}",
            b2.Volume, b1.Couleurs, b1.Matière);
                       
            Console.WriteLine("Nombre d'intance de class Boite est:{0}",Boite.NbInstanceBoite);
            Boite b3 = new Boite(24.0m, 56.0m, 74.0m, TypeMatière.métal);
            b3.Etiqueter("toto", true);
            b2.Etiqueter(etqDest, etqFragile);

            Console.ReadKey();
        }



      
    }
}
