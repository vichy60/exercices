using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_pgcd
{
    class Program
    {
        static void Main(string[] args)
        {
            Pgcd();
            Console.ReadKey();
        }
        static void Pgcd()
        {
            int p;
            int q;
            string saisie;

            Console.WriteLine("saisir la 1ere valeur de p");
            saisie= Console.ReadLine();
            p = int.Parse(saisie);
            Console.WriteLine("saisir la valeur q");
            saisie=Console.ReadLine();
            q = int.Parse(saisie);

                while (p!=q)
            {
                if (p > q)
                {
                    p = p - q;
                }
                else
                {
                    q = q - p;
                }
            }
            Console.WriteLine("PGCD est:" + p);

        }

    }
}
