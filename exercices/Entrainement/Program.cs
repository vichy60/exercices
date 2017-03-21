using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrainement
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Console.ReadKey();
        }

        static void Demo()
        {                                           
            string texte;
            string phrase;
            int nbPhrases, nbMots, nbCaractères; //plusieurs déclaration

            const double PI = 3.1415926;
            const string DEB_LISTE = " - ";

            phrase = "Le c# est un langage moderne et puissant";
            Console.WriteLine(phrase);
            texte = phrase;
            Console.WriteLine(texte);
            texte = texte + " il est utilisé pour toutes sortes d'applications\n";
            Console.WriteLine(texte);
            texte = texte + DEB_LISTE + "Application console\n";
            Console.WriteLine(texte);
            texte += DEB_LISTE + "Application fenêtrée Winforms et WPF\n";
            Console.WriteLine(texte);
            char lettre;
            lettre = phrase[3];
            Console.WriteLine(lettre);

            short s = 2;
            s++;// ou s+=1 ou s=s+1
            Console.Write("le résultat est:" + s +"\n");

            int[] tabPos = new int[5]; // declaration tableau 5 cases
            tabPos[0] = 3;
            tabPos[1] = 4;
            tabPos[2] = 40;
            tabPos[3] = 50;
            tabPos[4] = 60;

            // ou on peut ecrire : int[] tabPos = new int[5]{3,4,40....}

            Console.WriteLine(tabPos.Length); // Nb d'éléments du tableau
            for (int i=0; i<tabPos.Length; i++) // ou for(int i=tabPos.Length-1;i>=0;i--)

            {
                Console.WriteLine(tabPos[i]);
            }

            int j = 0;
            while (j < tabPos.Length)
            {
                Console.WriteLine(tabPos[j]);
                j++;
            }
           Console.Clear();
            Console.WriteLine(texte);

            nbPhrases = 0;
            for (int i=0;i<texte.Length; i++)
            { if(texte[i]=='\n')
                {
                    nbPhrases++;
                }
                        
            }
            Console.WriteLine("il y a " + nbPhrases + " phrases dans le texte");

            Console.Clear();

            nbMots = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i]==' '|| phrase[i] == '\'' || phrase[i] =='\n')
                {
                    nbMots++;
                }
            }
            nbMots++;
            Console.WriteLine("il y a " + nbMots + " mots dans le phrase");





        }
    }
}
