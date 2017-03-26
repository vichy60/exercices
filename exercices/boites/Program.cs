using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boites
{



    class Program
    {
        static void Main(string[] args)
        {
            Boite b1 = new Boite();
            //b1.Couleurs = TypeCouleurs.rouge;
            Console.WriteLine("Boite de volume {0} cm3, de couleur {1} et en {2}",
                b1.Volume, b1.Couleurs, b1.Matière);

            Console.ReadKey();
        }
        public enum TypeCouleurs
        {
            blanc,
            bleu,
            vert,
            jaune,
            orange,
            rouge,
            marron
        }
        public enum TypeMatière
        {
            carton,
            plastique,
            bois,
            métal
        }


        public class Boite
        {
            #region Champs privés
            private decimal _hauteur;
            private decimal _largeur;
            private decimal _longueur;
            private TypeCouleurs _couleurs;
            private TypeMatière _matière;
            #endregion

            /// <summary>
            /// initialisation (par un constructeur) des trois dimensions à 30.0m(attention decimaledonc mettre m et .0)
            /// </summary>
            public Boite()
            {
                _hauteur = 30.0m;
                _largeur = 30.0m;
                _longueur = 30.0m ;
                _matière = TypeMatière.carton;
            }


            
            #region propriétés
            public decimal Hauteur
            {
                get { return _hauteur; }
            }
            public decimal Largeur
            {
                get { return _largeur; }
            }
            public decimal Longueur
            {
                get { return _longueur; }
            }
            public TypeCouleurs Couleurs
            {
                get { return _couleurs; }
                set { _couleurs = value; }
            }

            public TypeMatière Matière
            {
                get { return _matière; }
            }
            public decimal Volume
            {
                get { return _hauteur* _largeur*_longueur; }
            }
            #endregion

            #region Méthode publique
            public void Etiqueter(string destinataire)
            {
            }
            public void Etiqueter(string destinataire, bool fragile)
            {

            }
            #endregion
        }
    }
}
