using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_Florian
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ancetre[] ancet = new Ancetre[4] { fils1, fille1, fils2, fille2 };
            

            fils fils1 = new fils();
            fils fils2 = new fils();
            fille fille1 = new fille();
            fille fille2 = new fille();
            Console.WriteLine(Ancetre.Compteur);

            var ancet=new Ancetre[4] { fils1 , fille1, fils2, fille2 };

            for (int i=0;i<ancet.Length; i++)
            {
                if (ancet[i].Mangeable())
                Console.WriteLine(ancet[i].Description);
                
            }

            Console.ReadKey();

        }
    }
}
