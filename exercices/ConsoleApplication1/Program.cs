using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using statuts;

namespace statuts
{

    [Flags]
    public enum Status
    {
        Aucun = 0,
        CDI = 1,
        CDD = 2,
        DP = 4,
        CHSCT = 8,
        SYND = 16

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Personne> list = new List<Personne> {new Personne("TURPIN","Abel",Status.CDI),
                                                    new Personne("BONNEAU","Achille",Status.CDD|Status.DP),
                                                    new Personne("BLONDEL","Adelphe",Status.CDI|Status.DP|Status.CHSCT|Status.SYND),
                                                    new Personne("BLACK","Aimé",Status.CDI),
                                                    new Personne("PERRIER","Aimée",Status.CDI),
                                                    new Personne("JORDAN","Alain",Status.CDD|Status.CHSCT),
                                                    new Personne("BAUDRY","Alban",Status.CDD),
                                                    new Personne("ORLEANS","Albert",Status.CDI|Status.DP|Status.SYND),
                                                    new Personne("VALOIS","Alexandra",Status.CDI|Status.SYND),
                                                    new Personne("WEST","Alexandre",Status.CDI|Status.DP|Status.CHSCT)
                                                    };

            Status masque1 = Status.CDD | Status.CHSCT;
            Status masque2 = Status.CDI | Status.DP;
            List<Personne> listCddChsct = new List<Personne>();
            List<Personne> listCdiDp = new List<Personne>();

            foreach (var p in list)
            {
                if ((p.Statu & masque1) == masque1) { listCddChsct.Add(p); }

                if ((p.Statu & masque2) == masque2)
                {
                    listCdiDp.Add(p);
                }
            }

            foreach (var i in listCddChsct)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();
            foreach (var i in listCdiDp)
            {
                Console.WriteLine(i.ToString());
            }

            foreach (var p in listCdiDp)
            {
                // p.Statu = p.Statu | Status.CHSCT;
                p.Statu |= Status.CHSCT;
                Console.WriteLine(p);
            }

            Console.ReadKey();





        }
    }
}
