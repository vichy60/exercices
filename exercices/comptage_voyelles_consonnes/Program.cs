using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comptage_voyelles_consonnes
{
    class Program
    {
        static void Main(string[] args)
        {
            int voyelle;
            int consonne;
            Console.WriteLine("saisir un mot");
            string mot = Console.ReadLine();
            CalculVoyelleConsonne( mot,out voyelle, out consonne);
            Console.WriteLine("\"{0}\" comprend {1} consonnes et {2} voyelles ", mot, consonne, voyelle);
            Console.ReadKey();


        }
        static void CalculVoyelleConsonne(string saisie,out int nbv,out int nbc)
        {
            nbv = 0;
            saisie = saisie.ToLower();
            for (int i = 0; i < saisie.Length; i++)
            {
                if ((saisie[i] == 'a') || (saisie[i] == 'e')|| (saisie[i] == 'i')||(saisie[i] == 'o')|| (saisie[i] == 'u')|| (saisie[i] == 'y'))
                {
                    nbv++;
                }
            }

            nbc =saisie.Length-nbv;

            


        }
    }
}
