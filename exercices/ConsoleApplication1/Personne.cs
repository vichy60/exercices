using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statuts
{
    class Personne
    {
        #region propriete
        public string Nom { get; }
        public string Prenom { get; }
        public Status Statu { get; set; }
        #endregion

        #region constructeur
        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;

        }
        public Personne(string nom, string prenom, Status statu) : this(nom, prenom)
        {
            Statu = statu;
        }
        #endregion

        #region methode
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Nom, Prenom, Statu);
        }


        #endregion
    }
}
