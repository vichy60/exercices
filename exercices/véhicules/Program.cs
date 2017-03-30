using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace véhicules
{

    public enum Energies
    {
        Aucune,
        Essence,
        Gazole,
        GPL,
        Electrique
    }




    public abstract class Véhicule : IComparable
    {
        #region propriétés automatiques
        public string Nom { get; }
        public int NbRoues { get; }

        public Energies Energie { get; }

        public virtual string Description { get { return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}", Nom, NbRoues, Energie); } }

        public abstract double PRK { get; }
        #endregion

        #region constructeur

        public Véhicule(string nom, int nbRoues, Energies energie)
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energie = energie;
        }

        public abstract void CalculerConso();

        public int CompareTo(object obj)
        {
            if (obj is Véhicule)
            {
                Véhicule v = (Véhicule)obj;
                if (PRK < v.PRK) return -1;
                else if (PRK > v.PRK) return 1;
                else return 0;
            }
            else
                throw new ArgumentException();
        }
        public class Voiture : Véhicule
        {
            public override string Description
            { get { return string.Format("Je suis une voiture \r\n " + base.Description); } }

            public override double PRK
            {
                get
                {
                    return 10.5;
                }
            }

            public Voiture(string nom, Energies energie) : base(nom, 4, energie)
            {

            }

            public override void CalculerConso()
            {
                throw new NotImplementedException();
            }
        }

        #endregion
        public class Moto : Véhicule
        {
            public Moto(string nom, int nbRoues, Energies energie) : base(nom, nbRoues, energie)
            {
            }

            public override string Description
            {
                get
                {
                    //return string.Format("Je suis une Moto\r\n" + base.Description);
                    return ("Je suis une Moto\r\n" + base.Description);
                }
            }

            public override double PRK
            {
                get
                {
                    return 0.4;
                }
            }

            public override void CalculerConso()
            {
                throw new NotImplementedException();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Voiture voiture1 = new Voiture("Clio", Energies.Essence);
                Console.WriteLine(voiture1.Description);
                //Véhicule Véhicule3 = new Véhicule();

                Console.ReadKey();

                Véhicule voiture2 = new Voiture("Peugeot", Energies.Gazole);
                Console.WriteLine(voiture2.Description);
                Véhicule moto2 = new Moto("Suzuki", 2, Energies.Essence);
                Console.WriteLine(moto2.Description);
                Console.ReadKey();


                object o = new object();

                try
                {
                    int res = voiture1.CompareTo(o);
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

                Console.ReadKey();

            }
        }
    }
}
