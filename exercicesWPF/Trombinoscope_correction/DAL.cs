using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Trombinoscope
{
	public class DAL
	{
		// Récupère les employés et leur territoires
		public static List<Employe> GetEmployesTerritoires()
		{
			List<Employe> lstEmployes = new List<Employe>();

			var connectString = Properties.Settings.Default.NorthwindConnectString;
			string queryString = @"select e.EmployeeID, LastName, FirstName, t.TerritoryID, t.TerritoryDescription
                        from Employees e
                        inner join EmployeeTerritories et on e.EmployeeID = et.EmployeeID
                        inner join Territories t on et.TerritoryID = t.TerritoryID
                        order by EmployeeID, TerritoryDescription";

			using (var connect = new SqlConnection(connectString))
			{
				var command = new SqlCommand(queryString, connect);
				connect.Open();

				var reader = command.ExecuteReader();

				while (reader.Read())
				{
					int idEmpl = (int)reader["EmployeeID"];

					// Si l'id de l'employe courant est != de celui du dernier de la liste,
					// on crée un nouvel employé
					Employe emp = null;
					if (lstEmployes.Count == 0 || lstEmployes[lstEmployes.Count - 1].Id != idEmpl)
					{
						emp = new Employe();
						emp.Id = (int)reader["EmployeeID"];
						emp.Prenom = (string)reader["FirstName"];
						emp.Nom = (string)reader["LastName"];
						emp.Territoires = new List<Territoire>();

						lstEmployes.Add(emp);
					}
					else emp = lstEmployes[lstEmployes.Count - 1];

					Territoire t = new Territoire();
					t.Code = (string)reader["TerritoryID"];
					t.Description = (string)reader["TerritoryDescription"];
					emp.Territoires.Add(t);
				}
			}

			return lstEmployes;
		}

		// Récupère les photos des employés
		/*public static List<ImageSource> GetPhotosEmployes()
		{
			 List<ImageSource> photos = new List<ImageSource>();

			 var connectString = Properties.Settings.Default.NorthwindConnectString;
			 string queryString = "SELECT EmployeeID, LastName, FirstName, Photo FROM Employees";

			 using (var connect = new SqlConnection(connectString))
			 {
				  var command = new SqlCommand(queryString, connect);
				  connect.Open();

				  var reader = command.ExecuteReader();

				  while (reader.Read())
				  {
						Byte[] tab = (Byte[])reader["Photo"];
						photos.Add(ConvertBytesToImageSource(tab));
				  }
			 }

			 return photos;
		}*/

		public static List<Employe> GeEmployes()
		{
			List<Employe> employes = new List<Employe>();

			var connectString = Properties.Settings.Default.NorthwindConnectString;
			string queryString = @"SELECT EmployeeID, LastName, FirstName, HireDate, Photo
                                    FROM Employees";

			using (var connect = new SqlConnection(connectString))
			{
				var command = new SqlCommand(queryString, connect);
				connect.Open();

				var reader = command.ExecuteReader();

				while (reader.Read())
				{
					Employe emp = new Employe();
					Byte[] tab = (Byte[])reader["Photo"];
                    if(reader["Photo"] != DBNull.Value)
					emp.Photo = ConvertBytesToImageSource(tab);
					emp.Nom = (string)reader["LastName"];
					emp.Prenom = (string)reader["FirstName"];
					if (reader["HireDate"] != DBNull.Value)
						emp.DateEmbauche = (DateTime)reader["HireDate"];
					employes.Add(emp);
				}
			}

			return employes;
		}

		private static ImageSource ConvertBytesToImageSource(Byte[] tab)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				// Les images stockées dans la base Northwind ont un en-tête de 78 octets 
				// qu'il faut enlever pour pouvoir les charger correctement
				ms.Write(tab, 78, tab.Length - 78);
				ImageSource image = BitmapFrame.Create(ms, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
				return image;
			}
		}
	}
}
