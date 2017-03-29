using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using boites;

namespace testboites
{
    [TestClass]
    public class Testboites
    {
        [TestMethod]

        public void TestNbInstances()
        {
            Boite[] tabBoite = new Boite[76];
            for(int i =0; i<tabBoite.Length;i++)
            {
                tabBoite[i]  = new Boite(5,5,5);
            }
            Assert.AreEqual(76,Boite.NbInstanceBoite);
        }

        [TestMethod]
        public void TestVolume()
        {
            Boite b1 = new Boite(5, 5, 5);
            Assert.AreEqual(125, b1.Volume);
        }
    }
}
                

       
