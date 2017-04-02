using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_Florian
{
    class fils : Ancetre
    {
        #region propriété automatique
        public override string Description { get; }

        #endregion

        #region constructeur

        public fils() : base()
        {
            Description = "je suis un fils";
        }
        #endregion
        #region methode publique
        //public override bool Mangeable()
        //{
        //    return true;
        //}

        #endregion
    }


    class fille : Ancetre
    {
        #region proprièté automatique

        public override string Description { get; }
        #endregion

        #region constructeur
        public fille() : base()
        {
            Description = "je suis une fille";
        }

        #endregion

        #region methode publique
        public override bool Mangeable()
        {
            return false;
        }

        #endregion
    }
}
