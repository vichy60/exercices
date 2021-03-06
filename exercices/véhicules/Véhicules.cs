﻿using System;
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

    public delegate void DelegueEntretien(Véhicule v);


    public abstract class Véhicule : IComparable
    {
        #region propriétés automatiques
        public string Nom { get; }
        public int NbRoues { get; }

        public Energies Energie { get; }

        public virtual string Description { get { return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}", Nom, NbRoues, Energie); } }

        public abstract double PRK { get; }

        public double Prix { get;}

        public Dictionary<DateTime, string> CarnetEntretien { get; }

        #endregion

        #region Constructeur
        public Véhicule()
        {
            var CarnetEntretien = new Dictionary<DateTime, string>();
        }
        public Véhicule(string nom,double prix): this()
        {
            Nom = nom;
            Prix = prix;
        }
        public Véhicule(string nom, int nbRoues, Energies energie):this()
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energie = energie;
        }
        public Véhicule( string nom2, int nbRoues2, Energies energie2, double prix) : this( nom2,nbRoues2,energie2)
        {
            Prix = prix;
        }


        #endregion


        #region Méthodes publiques

        public abstract void CalculerConso();

        //public int CompareTo(object obj)
        //{
        //    if (obj is Véhicule)
        //    {
        //        Véhicule v = (Véhicule)obj;
        //        if (PRK < v.PRK) return -1;
        //        else if (PRK > v.PRK) return 1;
        //        else return 0;
        //    }
        //    else
        //        throw new ArgumentException();

        //}

        public int CompareTo(object obj)
        {
            if ( obj is Véhicule)
            {
                Véhicule v = (Véhicule)obj;
                if (this.Prix < v.Prix) return -1;
                else if (this.Prix > v.Prix) return 1;
                else  return 0;

            }
            else
                throw new ArgumentException();
        }

        public void Entretenir(DateTime dateEntretien, DelegueEntretien entretienVéhicule )
        {
            CarnetEntretien.Add(dateEntretien,string.Empty);
            entretienVéhicule(this);
           
            
        }

        #endregion


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

        #region Constructeur

       
        public Voiture()
        {

        }

        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {

        }

        public Voiture( string nom,double prix) :base ( nom,prix )
        {

        }
        #endregion

        #region Méthodes publiques

        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }
        #endregion
    }


    public class Moto : Véhicule
    {
        #region MyRegion

        public Moto(string nom, int nbRoues, Energies energie) : base(nom, nbRoues, energie)
        {
        }

        #endregion
        public override string Description
        {
            get
            {
                return string.Format("Je suis une Moto\r\n" + base.Description);
            }
        }

        public override double PRK
        {
            get
            {
                return 0.4;
            }
        }
        #region Constructeur
        
        public Moto(double prix, string nom, int nbRoues, Energies energie) :base ( nom, nbRoues,energie, prix)
        { 

        }
        #endregion
        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }
    }
}
