using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExplorateurFichiers
{


    public delegate void DelegueExplorateur(FileInfo file1);


    public class Explorateur
    {
        #region MyRegion
             
      

        #endregion

        #region Constructeurs
        public Explorateur()
        {

        }
        #endregion

        #region Méthodes publiques

        public static void Explorer(string chemin,DelegueExplorateur délégué)
        {
            DirectoryInfo di = new DirectoryInfo(chemin);
            foreach (var fi in di.EnumerateFiles("*", SearchOption.AllDirectories))
            {
                délégué(fi);
            }

        }

        #endregion




    }


   


}
