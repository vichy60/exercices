//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace JobOverview
//{
//    class DAL
//    {
//        public static BindingList<Tache> GetTache()
//        {
            
//            var listTache = new BindingList<Tache>();

//            var connectString = Properties.Settings.Default.ProjetWinformsConnection;
//            string queryString = @"select * from jo.Tache t left outer join jo.TacheProd tp on t.IdTache=tp.IdTache ";



//            using (var connect = new SqlConnection(connectString))
//            {
//                var command = new SqlCommand(queryString, connect);

//                connect.Open();

//                using (SqlDataReader reader = command.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        GetProduitsFromDataReader(listTache, reader);
//                    }
//                }
//            }

//            return listTache;

//        }
//        private static void GetProduitsFromDataReader(BindingList<Tache> listProd, SqlDataReader reader)
//        {
//            var prod = new Produit();
//            prod.Id = (int)reader["ProductID"];
//            prod.Nom = (string)reader["ProductName"];
//            if (reader["CategoryID"] != DBNull.Value)
//                prod.Catégorie = (Int32)reader["CategoryID"];
//            if (reader["QuantityPerUnit"] != DBNull.Value)
//                prod.QtUnit = (string)reader["QuantityPerUnit"];
//            if (reader["UnitPrice"] != DBNull.Value)
//                prod.PrixUnit = (decimal)reader["UnitPrice"];
//            if (reader["UnitsInStock"] != DBNull.Value)
//                prod.Unit = (Int16)reader["UnitsInStock"];
//            if (reader["SupplierID"] != DBNull.Value)
//                prod.FournisseurId = (int)reader["SupplierID"];



//            listProd.Add(prod);

//        }






//    }
//}
