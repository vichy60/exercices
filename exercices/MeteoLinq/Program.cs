using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            

            AnalyseurLINQ an1 = new AnalyseurLINQ();
            an1.ChargerDonnées();
            an1.AfficherStats();
            Console.ReadKey();


            
        }
    }
}
