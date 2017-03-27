using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_nbpremier
{
    class Program
    {
        static void Main(string[] args)
        {
          Nbpremier();
          Console.ReadKey();

        }

        static void Nbpremier()
        {
            int n; //nombre à trouver
            string saisie;
            int compt;
            int chiffreTesté = 2;

            compt = 1;
            saisie = Console.ReadLine();
            n= int.Parse(saisie);
            if (n==0)
            {
                Console.WriteLine("aucun nombre premier");
            }
            else
            {
                if(n==1)
                {
                    Console.WriteLine("");
                }
            }

            if(chiffreTesté%n==0)
            {
                compt++;
            }
            else
            {
                n++;
            }
        }

    }
}
