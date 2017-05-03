using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    class DAL
    {
        public static void ExemplesLINQtoXML()
        {
            // Chargement du fichier xml 
            XDocument doc = XDocument.Load(@"D:\ycappelle\winforms\CollectionsBD.xml");

           //•	Récupérer les titres des albums qui sont sortis dans les années 60
            var titres60 = doc.Descendants("Album").Where (a=> a.Attribute("Année").Value.StartsWith ("196")).Attributes("Titre").Select(t => t.Value);
            

            // Ajout de l'auteur Pascal Dabère dans la liste des auteurs de Lucky Luke
            var LuckyLuke = doc.Descendants("CollectionBD").Where(n => n.Attribute("Nom").Value == "Lucky Luke").First();

            LuckyLuke.Descendants("Auteurs").First().Add(new XElement("Auteur", "Pascal Dabère"));
           LuckyLuke.Save(@"D:\ycappelle\winforms\LuckyLuke.xml");


            //•	Ajouter l'album suivant dans la collection des Lucky Luke : "Le pont sur le Mississippi", écrit par Morris et sorti en 1994
            //on obtient au préalable l'Id du dernier album.
            var id = LuckyLuke.Descendants("Album").Attributes("Id").Max(a => (int)a);
            LuckyLuke.Descendants("Albums").First().Add(new XElement("Album", new XAttribute("Id", id+1),
                                                                               new XAttribute("Année", "1994"),
                                                                            new XAttribute("Titre", "Le pont sur le Mississippi")));
                                                                            

            LuckyLuke.Save(@"D:\ycappelle\winforms\LuckyLuke.xml");



            //•	Mettre en majuscules le titre de l’album N° 15 d’Astérix

            var asterix = doc.Descendants("CollectionBD").Where(n => n.Attribute("Nom").Value == "Astérix").First();
            var titre = doc.Descendants("Album").Attributes("Titre").Select(t => t.Value);


          
        }
    }
}
