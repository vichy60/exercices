using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boites
{
    public enum TypeFormat/*Formats*/
    {
        XS,
        S,
        M,
        L,
        XL
    }
    public class Etiquette
    {
        #region MyRegion
        public string Texte { get; set; }
        public TypeFormat Format { get; set; }

        public TypeCouleurs Couleur { get; set; }
        #endregion

    }
}
