using System;
using System.Collections.Generic;
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
            string queryString = @"select EmployeeId,LastName,FirstName,Photo from Employees";

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
            var pers = new Personne();
            pers.Photo = new Image();
            pers.EmployeeId = (int)reader["EmployeeID"];       // ou bien (int)reader["EmployeeID"];
            pers.Nom = (string)reader["LastName"];     // ...
            pers.Prenom = (string)reader["FirstName"];
            pers.NomPrenom = pers.Nom + " " + pers.Prenom;

            if (reader["Photo"] != DBNull.Value)
            {
                pers.Photo.Source = ConvertBytesToImageSource((Byte[])reader["Photo"]);
                pers.Photo.Width = 200;
            }
            listPersonnes.Add(pers);
        }

    }
}
