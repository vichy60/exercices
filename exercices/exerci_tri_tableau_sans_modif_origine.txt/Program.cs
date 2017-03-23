using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerci_tri_tableau_sans_modif_origine
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] table = new string[] { "yannick", "a", "Florian", "Virginie", "f", "a" }; // pas obligé de mettre le 4 dans string[4], on peut aussi faire string[] table={"yannick",....}
            AffichageTableau(table);
            string[] tabTriée = TriTableau(table);
            AffichageTableau(tabTriée);
            AffichageTableau(table);
            Console.ReadKey();
        }
        static void AffichageTableau(string[] tableau)
        {
            int i = 0;                              // ou for(int i=0;i<tableau.Length;i++)
            int n = tableau.Length;                    //
            while (i < n)                                 //
            {
                Console.Write(tableau[i] + " ");
                i++;
            }
            Console.WriteLine();
        }

        static string[] TriTableau(string[] tableau)
        {
            int j;
            string[] tab = new string[tableau.Length];
            for (j = 0; j < tableau.Length; j++)
            {
                tab[j] = tableau[j];
            }
            string sup;
            string inf;
            int i = 0;
            int n = tab.Length;
            bool fini;
            do

            //bool aumoinsunepermut=true

            {                                                                           // while(auMoinsUnePermut=true {auMoinsUnePermut=false;
                fini = true;


                for (i = 0; i < n - 1; i++)                                                // ou for(int i=0;i<tableau.Length;i++) {
                {                                                                           //if(i==0) continue;   (pour sauter la premiere valeur sans faire les instruction du for)
                    if (tab[i].CompareTo(tab[i + 1]) > 0)                           //int resComp=tableau[i-1].CompareTo(tableau[i]);
                    {                                                                       //if (resComp>0)
                                                                                            // {       string temp=tableau[i];  tableau[i]=tableau[i-1];tableau[i-1]=temp; auMoinsUnePermut=true;}   
                        fini = false;                                                       // }
                                                                                            ///}
                        sup = tab[i];
                        inf = tab[i + 1];
                        tab[i] = inf;
                        tab[i + 1] = sup;

                    }

                }

            } while (!fini);
            return tab;
        }

    }
}
