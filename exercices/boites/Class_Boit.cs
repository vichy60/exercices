using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boites
{
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
        private static int _nbInstanceBoite = 0;
        private Etiquette _etiquetteDest;
        private Etiquette _etiquetteFragile;
        //private TypeCouleurs _couleurs;
        //private TypeMatière _matière;
        #endregion

        /// <summary>
        /// initialisation (par un constructeur) des trois dimensions à 30.0m(attention decimale donc mettre m et .0)
        /// </summary>
        public Boite()
        {
            _hauteur = 30.0m;
            _largeur = 30.0m;
            _longueur = 30.0m;
            /* _matière*/
            Matière = TypeMatière.carton;
            _nbInstanceBoite++;
        }
        public Boite(decimal hauteur, decimal largeur, decimal longueur) : this()
        {
            _hauteur = hauteur;
            _largeur = largeur;
            _longueur = longueur;
        }
        public Boite(decimal hauteur, decimal hargeur, decimal longueur, TypeMatière matière) : this(hauteur, hargeur, longueur)
        {
            Matière = matière;
        }



        #region propriétés
        public static int NbInstanceBoite
        { get { return _nbInstanceBoite; } }
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
        public TypeCouleurs Couleurs { get; set; }
        // {
        //get { return _couleurs; }
        //set { _couleurs = value; }
        // }

        public TypeMatière Matière { get; private set; }
        //  {
        //    get { return _matière; }
        //}
        public decimal Volume
        {
            get { return _hauteur * _largeur * _longueur; }
        }
        #endregion

        #region Méthode publique
        public void Etiqueter(string destinataire)
        {
            _etiquetteDest = new Etiquette { Couleur = TypeCouleurs.blanc, Format = TypeFormat.L, Texte = destinataire };// on a pas de constructeur sur la class etiquette donc on utilise un initialisateur

        }
        public void Etiqueter(string destinataire, bool fragile)//composition
        {

            if (fragile)
            {
                _etiquetteFragile = new Etiquette { Couleur = TypeCouleurs.rouge, Format = TypeFormat.S, Texte = "FRAGILE" };
            }
            Etiqueter(destinataire);
       }
        public void Etiqueter(Etiquette etqDest, Etiquette etqFragile) //agregation
        {
            _etiquetteDest = etqDest;
            _etiquetteFragile = etqFragile;
        }
        _


        public bool Compare(Boite autreboite)
        {
            return (this.Hauteur == autreboite.Hauteur && this.Largeur == autreboite.Largeur && this.Longueur == autreboite.Longueur && this.Matière == autreboite.Matière);
            // ou if (this.Hauteur == autreboite.Hauteur && this.Largeur == autreboite.Largeur && this.Longueur == autreboite.Longueur && this.Matière == autreboite.Matière);
        }
        #endregion
    }
}
