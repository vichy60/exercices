using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace véhicules
{

    public class Program
    {
        static void Main(string[] args)
        {
            var voiture1 = new Voiture("Clio", Energies.Essence);
            Console.WriteLine(voiture1.Description);
            //Véhicule Véhicule3 = new Véhicule();

            Console.ReadKey();

            Véhicule voiture2 = new Voiture("Peugeot", Energies.Gazole);
            Console.WriteLine(voiture2.Description);
            Véhicule moto2 = new Moto("Suzuki", 2, Energies.Essence);
            Console.WriteLine(moto2.Description);
            Console.ReadKey();


            try
            {
                int res = voiture1.CompareTo(voiture2);
                if (res < 0)
                    Console.WriteLine("{0} est plus économique que {1}", voiture1.Nom, voiture2.Nom);
                else if (res > 0)
                    Console.WriteLine("{0} est plus économique que {1}", voiture2.Nom, voiture1.Nom);
                else
                    Console.WriteLine("{0} a le même PRK que {1}", voiture1.Nom, voiture2.Nom);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Comparaison impossible");
            }

            Véhicule voiture4 = new Voiture("Mégane", 19000);
            Véhicule voiture5 = new Voiture("Intruder", 13000);
            Véhicule voiture6 = new Voiture("Enzo", 380000);
            Véhicule voiture7 = new Voiture("Yamaha", 11000);

            var dic = new Dictionary<string, Véhicule>(); //Dictionary<string, Véhicule> dic = new Dictionary<string, Véhicule>();
            dic.Add(voiture4.Nom, voiture4);
            dic.Add(voiture5.Nom, voiture5);
            dic.Add(voiture6.Nom, voiture6);
            dic.Add(voiture7.Nom, voiture7);
            Console.ReadKey();
        }
        public static void ChangerPneus(Véhicule v)
        {
            var date = v.CarnetEntretien.Keys.Last();


        }

        public static void Vidanger(Véhicule v)
        {

        }

        public static void RetoucherPeinture(Véhicule v)
        {

        }
    }
    
}
