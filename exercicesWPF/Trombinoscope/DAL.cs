using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Trombinoscope
{
    public class DAL
    {
        private static ImageSource ConvertBytesToImageSource(Byte[] tab)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Les images stockées dans la base Northwind ont un en-tête de 78 octets 
                // qu'il faut enlever pour pouvoir les charger correctement
                ms.Write(tab, 78, tab.Length - 78);
                ImageSource image = BitmapFrame.Create(ms, BitmapCreateOptions.None,
                                      BitmapCacheOption.OnLoad);
                return image;
            }
        }

        public static List<Personne> GetPersonnes()
        {
            // Liste de photos de personnes pour stocker le résultat de la requête
            var listPersonnes = new List<Personne>();

            var connectString = Properties.Settings.Default.ConnectString;
            string queryString = @"select e.EmployeeId,e.LastName,e.FirstName,e.Photo,t.TerritoryID,t.TerritoryDescription,
                                    t.RegionID from Employees e
                                    inner join EmployeeTerritories et on e.EmployeeID=et.EmployeeID
                                    inner join Territories t on et.TerritoryID=t.TerritoryID";

            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);
                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetPersonnesFromDataReader(listPersonnes, reader);
                    }
                }
            }

            return listPersonnes;
        }
        private static void GetPersonnesFromDataReader(List<Personne> listPersonnes, SqlDataReader reader)
        {

            if (listPersonnes.Count == 0 || (int)reader["EmployeeID"] != listPersonnes.Last().EmployeeId)
            {
                var pers = new Personne();

                pers.EmployeeId = (int)reader["EmployeeID"];       // ou bien (int)reader["EmployeeID"];
                pers.Nom = (string)reader["LastName"];     // ...
                pers.Prenom = (string)reader["FirstName"];
                pers.NomPrenom = pers.Nom + " " + pers.Prenom;


                if (reader["Photo"] != DBNull.Value)
                {
                    pers.Photo = ConvertBytesToImageSource((Byte[])reader["Photo"]);

                }
                listPersonnes.Add(pers);


            }
            if (listPersonnes.Last().Territoires == null)
            {
                listPersonnes.Last().Territoires = new List<Territoire>();
            }
            var ter = new Territoire();
            ter.TerritoryID = reader["TerritoryID"].ToString();
            ter.TerritoryDescription = reader["TerritoryDescription"].ToString();

            listPersonnes.Last().Territoires.Add(ter);
        }


        public static void InsertPersonne(Personne p)
        {
            //recup de la chaine de connexion
            var connectString = Properties.Settings.Default.ConnectString;
            //écriture requete
            string queryString = @"insert into Employees(LastName,FirstName) values(@Nom,@Prenom)";
            //parametres de la requete
            var paramNom = new SqlParameter("@Nom", DbType.String);
            paramNom.Value = p.Nom;
            var paramPrenom = new SqlParameter("@Prenom", DbType.String);
            paramPrenom.Value = p.Prenom;
            //création de la connexion à partir de la chaine de connexion
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);
                command.Parameters.Add(paramNom);
                command.Parameters.Add(paramPrenom);

                connect.Open();
                command.ExecuteNonQuery();

            }
        }
    }
}