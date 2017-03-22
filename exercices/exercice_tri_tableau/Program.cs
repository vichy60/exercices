using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_tri_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] table = new string[] { "yannick", "a", "Florian", "Virginie", "f", "a" }; // pas obligé de mettre le 4 dans string[4], on peut aussi faire string[] table={"yannick",....}
            AffichageTableau(table);
            TriTableau(table);
            AffichageTableau(table);
            Console.ReadKey();
        }
        static void AffichageTableau(string[] tableau)
        {
            int i = 0;                              // ou for(int i=0;i<tableau.Length;i++)
            int n = tableau.Length;                    //
            while (i<n)                                 //
            {
                Console.Write(tableau[i] + " ");
                i++;
            }
            Console.WriteLine();
        }

        static void TriTableau(string[] tableau)
        {
            string sup;
            string inf;
            int i = 0;
            int n = tableau.Length;
            bool fini;
            do
                                                                                        
                                                                                        //bool aumoinsunepermut=true
            
            {                                                                           // while(auMoinsUnePermut=true {auMoinsUnePermut=false;
                fini = true;


                for (i = 0; i < n-1; i++)                                                // ou for(int i=0;i<tableau.Length;i++) {
                {                                                                           //if(i==0) continue;   (pour sauter la premiere valeur sans faire les instruction du for)
                    if (tableau[i].CompareTo(tableau[i + 1]) > 0)                           //int resComp=tableau[i-1].CompareTo(tableau[i]);
                    {                                                                       //if (resComp>0)
                                                                                            // {       string temp=tableau[i];  tableau[i]=tableau[i-1];tableau[i-1]=temp; auMoinsUnePermut=true;}   
                        fini = false;                                                       // }
                                                                                            //}
                        sup = tableau[i];
                        inf = tableau[i+1];
                        tableau[i] = inf;
                        tableau[i+1] = sup;

                    }

                }

            } while (!fini);
        }

    }
}
