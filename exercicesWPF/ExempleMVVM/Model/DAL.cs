using ExempleMVVM.Entités;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleMVVM.Model
{
    static public class DAL
    {
        static public List<Donnée> ChargerDonnées()
        {
            List<Donnée> données = new List<Donnée>();

            données.Add(new Donnée() { Nom = "Donnée1", Description = "Description1" });
            données.Add(new Donnée() { Nom = "Donnée2", Description = "Description2" });
            données.Add(new Donnée() { Nom = "Donnée3", Description = "Description3" });
            données.Add(new Donnée() { Nom = "Donnée4", Description = "Description4" });

            return données;
        }
    }
}
