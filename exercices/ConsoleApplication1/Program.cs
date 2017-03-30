using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statuts
{

    public class Personne
    {
        #region propriétés automatiques
        public string Nom { get; }
        public string Prenom { get; }
        public Statu Statut { get; }
        #endregion
        #region Constructeur
        public Personne(string nom,string prenom,Statu statut)
        {
            Nom = nom;
            Prenom = prenom;
            Statut = statut;
        }
        #endregion
        #region Méthodes
        public override string ToString()
        {
            return base.ToString() + string.Format("{ 0}{ 1}{ 2}",Nom,Prenom,Statut);
        }

        #endregion

    }

    [Flags]
    public enum Statu
    {
        Aucun=0,
        CDI=1,
        CDD=2,
        DP=4,
        CHSCT=8,
        SYND=16
    }
    


    class Program
    {
        static void Main(string[] args)
        {
            Statu statu1 = Statu.CDI;
            Statu statu2 = Statu.CDD | Statu.DP;
            Statu statu3 = Statu.CDI | Statu.DP | Statu.CHSCT | Statu.SYND;
            Statu statu4 = Statu.CDD | Statu.CHSCT;
            Statu statu5 = Statu.CDD;
            Statu statu6 = Statu.CDI | Statu.DP | Statu.SYND;
            Statu statu7 = Statu.CDI | Statu.SYND;
            Statu statu8 = Statu.CDI | Statu.DP | Statu.CHSCT;
        







            Personne p1 = new Personne("TURPIN", "Abel", statu1);
            Personne p2 = new Personne("BONNEAU", "Achille", statu2);
            Personne p3 = new Personne("BLONDEL", "Adelphe", statu3);
            Personne p4 = new Personne("BLACK", "Aimé",statu1 );
            Personne p5 = new Personne("PERRIER", "Aimée", statu1);
            Personne p6 = new Personne("JORDAN", "Alain", statu4);
            Personne p7 = new Personne("BAUDRY", "Alban", statu6);
            Personne p8 = new Personne("ORLEANS", "Albert", statu7);
            Personne p9 = new Personne("VALOIS", "Alexandra", statu8);
            Personne p10 = new Personne("WEST", "Alexandre", statu9);





            List<Personne> listPers = new List<Personne>();
            listPers.Add(p3)
        }
    }
}
