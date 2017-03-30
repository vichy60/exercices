using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_Florian
{
    public abstract class Ancetre : IMangeable
    {
        #region MyRegion

        public virtual string Description { get; }
        public static int Compteur { get; private set; }

        #endregion

        #region Constructeur
        public Ancetre()
        {
            Description = "je suis l'ancètre";
            Compteur++;
            
        }

        public virtual bool Mangeable()
        {
            return true;
           
        }

        #endregion
    }
}
