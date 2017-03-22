using System; // pour connaitre la console sinon on utilise system.console
using System.Collections.Generic;
using System.Linq;                  //espace de noms
using System.Text;
using System.Threading.Tasks;

namespace NombresPremier
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			
			Console.Write("Combien de nombres premiers : "); // string réponse;
                                                             // réponse = Console.ReadLine();
                                                              // n=int.parse(réponse);

			n = Int32.Parse(System.Console.ReadLine()); // "system" pas obligatoire
            CalculerNbPremiers(n);
            CalculerNbPremiers(15);
            CalculerNbPremiers(19);

            Console.ReadKey();
        }

        static void CalculerNbPremiers(int nbPremier)
        {
            int divis, nbr, cptPremier = 0;
            bool estPremier;
            Console.Write(2 + " ");
            nbr = 3;
            while (cptPremier < nbPremier - 1)
            {
                divis = 2;
                estPremier = true;
                do
                {
                    if (nbr % divis == 0) estPremier = false;
                    else divis = divis + 1; // divis +=divis ou divis++
                }
                while ((divis <= nbr / 2) && (estPremier == true));
                if (estPremier)
                {
                    cptPremier++;
                    System.Console.Write(nbr+" ");
                }
                nbr++;
            }
            Console.Write('\n');
        }
    }
}
