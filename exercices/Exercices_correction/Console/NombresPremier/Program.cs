using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresPremier
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			Console.Write("Combien de nombres premiers : ");
			n = Int32.Parse(Console.ReadLine());
			CalculerNbPremiers(n, 5);
			CalculerNbPremiers(15, 5);
			CalculerNbPremiers(19, 9);

			Console.ReadKey();
		}

		static void CalculerNbPremiers(int nbPremiers, int x)
		{
			int divis, nbr, cptPremiers = 0;
			bool estPremier;

			Console.WriteLine("2");
			nbr = 3;
			while (cptPremiers < nbPremiers - 1)
			{
				divis = 2;
				estPremier = true;
				do
				{
					if (nbr % divis == 0)
						estPremier = false;
					else
						divis++;
				}
				while (divis <= nbr / 2 && estPremier);
				if (estPremier)
				{
					cptPremiers++;
					System.Console.WriteLine(nbr);
				}
				nbr++;
			}
		}
	}
}
