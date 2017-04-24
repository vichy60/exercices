using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorateurFichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pathCorrect = false;
            do
            {

                try
                {
                    string path;
                    Console.WriteLine("Saisissez le chemin du dossier à explorer :");
                    path = Console.ReadLine();

                    Analyseur analyse = new Analyseur();
                    analyse.AnalyserDossier(path);
                    pathCorrect = true;


                    Console.WriteLine("{0} fichiers, dont {1} fichiers .cs", analyse.fichierTotal, analyse.fichierCs);
                    Console.WriteLine("Nom de fichier le plus long:\n {0}", analyse.fichierLong);
                    Console.WriteLine("Fichiers projets C#:\n");
                    foreach (var item in analyse.listFichierProjet)
                    {
                        Console.WriteLine(item);
                    }

                }
                catch (DirectoryNotFoundException e)
                {

                    Console.WriteLine("Ce repertoire n'exite pas !! \n" + e.Message);
                } 
            } while (!pathCorrect);
            Console.ReadKey();
        }

    }
}
