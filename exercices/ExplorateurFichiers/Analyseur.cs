using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExplorateurFichiers
{
    public class Analyseur
    {
        #region propriétés

        public int fichierTotal { get; private set; }
        public int fichierCs { get; private set; }

        public string fichierLong { get; private set; }
        public List<string> listFichierProjet { get; }
        #endregion


        #region Constructeurs
        public Analyseur()
        {
            fichierLong = string.Empty;
            listFichierProjet = new List<string>();
    }
        #endregion

        #region Méthodes publiques
        public void AnalyserDossier(string chemin)

        {
            DelegueExplorateur délégué = null;

            délégué += CompterFichiers;
            délégué += AnalyserNom;
            délégué += FiltrerProjet;

            Explorateur.Explorer(chemin, délégué);

        }


        public void CompterFichiers(FileInfo file1)
        {
            if (file1.Extension == ".cs")
            {
                fichierCs++;
            }
            fichierTotal++;
        }


        public void AnalyserNom(FileInfo file1)
        {
            if (file1.Length > fichierLong.Length)
            {
                fichierLong = file1.FullName;
            }

        }
        public void FiltrerProjet(FileInfo file1)
        {
            if (file1.Extension == ".csproj")
            { 
                listFichierProjet.Add(file1.Name);
            }
        }


        #endregion

    }
}
