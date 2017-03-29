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
    public class Véhicule
    {
        #region propriétés automatiques
        public string Nom { get; }
        public int NbRoues { get; }

        public Energies Energie { get; }

        public virtual string Description { get { return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}", Nom, NbRoues, Energie); } }

        #endregion

        #region constructeur

        public Véhicule(string nom, int nbRoues, Energies energie)
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energie = energie;
        }
    }
    public class Voiture : Véhicule
    {
        public override string Description
        { get { return string.Format("Je suis une voiture \r\n " + base.Description); } }

        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {

        }


    }

    public class Moto : Véhicule
    {
        public override string Description
        { get { return string.Format("Je suis une moto \r\n " + base.Description); } }

        public Moto(string nom, Energies energie) : base(nom, 2, energie)
        {

        }

        #endregion

        class Program
        {
            static void Main(string[] args)
            {
                Voiture voiture1 = new Voiture("Clio", Energies.Essence);
                Console.WriteLine(voiture1.Description);


                Véhicule voiture2 = new Voiture("Peugeot", Energies.Gazole);
                Console.WriteLine(voiture2.Description);
                Véhicule Moto2 = new Moto("suzuki", Energies.Electrique);
                Console.WriteLine(Moto2.Description);
                Console.ReadKey();
            }
        }
    }
}