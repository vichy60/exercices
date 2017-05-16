using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Saisie_de_taches
{
    public static class AccesDonnees
    {
        public static List<Tache> ChargerTaches()
        {
            var listTache = new List<Tache>();
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Tache>), new XmlRootAttribute("Taches"));

            using (var stream = new StreamReader(@"../../Taches.xml"))
            {
                //ne pas oublier de caster le retour de la méthode Deserialize qui renvoie un  objet.
                listTache =(List<Tache>) deserializer.Deserialize(stream);
            }

                return listTache;
        }
    }
}