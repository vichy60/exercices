using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public static class DAL
    {
        // Récupération de la liste des régions de produits
        public static void GetRegion()
        {
            // On récupérer la chaîne de connexion stockée dans le fichier App.config
            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            // On écrit la requête SQL à exécuter
            string queryString = "SELECT RegionId, RegionDescription FROM Region";

            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête,
                // et en utilisant la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);

                // On ouvre la connexion
                connect.Open();

                // On exécute la requête en récupérant son résultat 
                // dans un objet SqlDataRedader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On lit et on affiche les lignes de résultat en boucle
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}",
                           reader[0], reader[1]));
                    }
                }
            }

        }
        public static List<Supplier> GetSuppliers(string pays)
        {
            // Liste de suppliers pour stocker le résultat de la requête
            var listSuppliers = new List<Supplier>();

            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"select SupplierID,CompanyName,ContactName,ContactTitle,
                                        Address,City,Region,PostalCode,Country    from Suppliers where country=@pays";

            SqlParameter param = new SqlParameter("@pays", System.Data.DbType.String);
            param.Value = pays;

            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);
                command.Parameters.Add(param);
                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetSuppliersFromDataReader(listSuppliers, reader);
                    }
                }
            }

            return listSuppliers;




        }
        private static void GetSuppliersFromDataReader(List<Supplier> listSuppliers, SqlDataReader reader)
        {
            var suppl = new Supplier();
            suppl.SupplierID = (int)reader["SupplierID"];       // ou bien (int)reader["EmployeeID"];
            suppl.CompanyName = (string)reader["CompanyName"];   // ou  (string)reader["TitleOfCourtesy"];
            if (reader["ContactName"] != DBNull.Value)
                suppl.ContactName = (string)reader["ContactName"];
            if (reader["ContactTitle"] != DBNull.Value)
                suppl.ContactTitle = (string)reader["ContactTitle"];
            if (reader["Address"] != DBNull.Value)
                suppl.Address = (string)reader["Address"];
            if (reader["City"] != DBNull.Value)
                suppl.City = (string)reader["City"];
            if (reader["Region"] != DBNull.Value)
                suppl.Region = (string)reader["Region"];
            if (reader["PostalCode"] != DBNull.Value)
                suppl.PostalCode = (string)reader["PostalCode"];
            if (reader["Country"] != DBNull.Value)
                suppl.Country = (string)reader["Country"];

            listSuppliers.Add(suppl);

        }

        ///

        public static List<string> GetPays()
        {
            // Liste de personnes pour stocker le résultat de la requête
            string pays = string.Empty;
            List<string> list = new List<string>();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"select distinct Country    from Suppliers order by Country";

            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);
                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["Country"] != DBNull.Value)
                            pays = (string)reader["Country"];
                        list.Add(pays);
                    }
                }
            }

            return list;




        }

        public static string GetNbProduits(string pays)
        {

            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"select count (*) from Products as p
                                 inner join Suppliers as s on p.SupplierID=s.SupplierID
                                   where s.Country= @pays";
            SqlParameter param = new SqlParameter("@pays", System.Data.DbType.String);
            param.Value = pays;

            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);
                command.Parameters.Add(param);
                connect.Open();

                return string.Format("{0} produits pour le pays {1}", command.ExecuteScalar().ToString(), pays);

            }




        }

        public static List<Commande> GetCom(string ClientId)
        {
            // Liste de Commande pour stocker le résultat de la requête
            var listCom = new List<Commande>();

            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"select CommandeId,dateCommande,dateEnvoi,nbArticle,MontantTotal,FraisEnvoi from ufn_listCommandeClient(@ClientId)";

            SqlParameter param = new SqlParameter("@ClientId", System.Data.DbType.String);
            param.Value = ClientId;

            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);
                command.Parameters.Add(param);
                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetCommandeFromDataReader(listCom, reader);
                    }
                }
            }

            return listCom;




        }
        private static void GetCommandeFromDataReader(List<Commande> listCom, SqlDataReader reader)
        {

            //todo controle valeurs null à finir
            var com = new Commande();
            com.CommandeId = (int)reader["CommandeID"];
            if (reader["dateCommande"] != DBNull.Value)
                com.DateCommande = (DateTime)reader["dateCommande"];
            if (reader["dateEnvoi"] != DBNull.Value)
                com.DateLivraion = (DateTime)reader["dateEnvoi"];
            if (reader["nbArticle"] != DBNull.Value)
                com.NbProduitsCom = (int)reader["nbArticle"];
            if (reader["MontantTotal"] != DBNull.Value)
                com.MontantCom = (decimal)reader["MontantTotal"];
            if (reader["FraisEnvoi"] != DBNull.Value)
                com.Frais = (decimal)reader["FraisEnvoi"];


            listCom.Add(com);

        }

        // récupération des produits de la base Northwind
        public static BindingList<Produit> GetProd()
        {

            var listProd = new BindingList<Produit>();

            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"select ProductID,ProductName,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,SupplierID from Products where Discontinued=0";



            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);

                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetProduitsFromDataReader(listProd, reader);
                    }
                }
            }

            return listProd;

        }
        private static void GetProduitsFromDataReader(BindingList<Produit> listProd, SqlDataReader reader)
        {
            var prod = new Produit();
            prod.Id = (int)reader["ProductID"];
            prod.Nom = (string)reader["ProductName"];
            if (reader["CategoryID"] != DBNull.Value)
                prod.Catégorie = (Int32)reader["CategoryID"];
            if (reader["QuantityPerUnit"] != DBNull.Value)
                prod.QtUnit = (string)reader["QuantityPerUnit"];
            if (reader["UnitPrice"] != DBNull.Value)
                prod.PrixUnit = (decimal)reader["UnitPrice"];
            if (reader["UnitsInStock"] != DBNull.Value)
                prod.Unit = (Int16)reader["UnitsInStock"];
            if (reader["SupplierID"] != DBNull.Value)
                prod.FournisseurId = (int)reader["SupplierID"];



            listProd.Add(prod);

        }

        // Méthode d'ajout (bouton +) de la FormProduits  -- exercice5
        public static void AjouProd(Produit newProd)
        {
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"insert Products (ProductName,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,SupplierID)
                                values (@Nom,@Categorie,@QtUnit,@PrixUnit,@Unit,@FournisseurId)";

            SqlParameter paramNom = new SqlParameter("@Nom", System.Data.DbType.String);
            paramNom.Value = newProd.Nom;
            SqlParameter paramCat = new SqlParameter("@Categorie", System.Data.DbType.Int32);
            paramCat.Value = newProd.Catégorie;
            SqlParameter paramQt = new SqlParameter("@QtUnit", System.Data.DbType.String);
            paramQt.Value = newProd.QtUnit;
            SqlParameter paramPri = new SqlParameter("@PrixUnit", System.Data.DbType.Decimal);
            paramPri.Value = newProd.PrixUnit;
            SqlParameter paramUnit = new SqlParameter("@Unit", System.Data.DbType.Int16);
            paramUnit.Value = newProd.Unit;
            SqlParameter paramFour = new SqlParameter("@FournisseurId", System.Data.DbType.Int32);
            paramFour.Value = newProd.FournisseurId;



            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);
                command.Parameters.Add(paramNom);
                command.Parameters.Add(paramCat);
                command.Parameters.Add(paramQt);
                command.Parameters.Add(paramPri);
                command.Parameters.Add(paramUnit);
                command.Parameters.Add(paramFour);

                connect.Open();

                command.ExecuteNonQuery();




            }
        }

        // Méthode d'suppression produit (bouton -) de la FormProduits  -- exercice 5
        public static bool SupProd(Produit supProd)
        {
            // Préparation des requêtes et paramètres
            bool supOk = false;
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"delete from Products where ProductID = @supProdId";

            SqlParameter param = new SqlParameter("@supProdId", System.Data.DbType.String);
            param.Value = supProd.Id;

            using (var connect = new SqlConnection(connectString))
            {


                // Ouverture de la connexion
                connect.Open();

                // Début de la transaction
                SqlTransaction tran = connect.BeginTransaction();

                try
                {
                    // Création et exécution des commandes, en leur affectant la transaction
                    var command = new SqlCommand(queryString, connect, tran);
                    command.Parameters.Add(param);

                    command.ExecuteNonQuery();

                    // Validation de la transaction s'il n'y a pas eu d'erreur
                    tran.Commit();
                    supOk = true;


                }
                catch (SqlException e)
                {
                    if (e.Number == 547)
                    {
                        MessageBox.Show("Impossible de supprimer le produit", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Annulation de la transaction en cas d'erreur
                        tran.Rollback();
                    }
                    else
                        throw;   // Remontée de l'erreur à l'appelant

                }





            }

            return supOk;
        }


        public static void SuppEnMasse(List<Produit> listId)
        {

            // Ecriture de la requête d'insertion en masse
            // Le paramètre @table contiendra les enregistrements à insérer
            string req = @"update Products set Discontinued=1 
                           from @table t 
                            inner join Products p on t.ID = p.ProductID";

            //where ProductID=t.Id;

            // Création du paramètre de type table mémoire
            // /!\ Le type TypeTabId doit être créé au préalable dans la base
            /*
            create type TypeTabId as table
              (
              ID int
              )

              */

            var param = new SqlParameter("@table", SqlDbType.Structured);
            DataTable tableProd = GetDataTableForProd2(listId);
            param.TypeName = "TypeTabId";
            param.Value = tableProd;

            using (var cnx = new SqlConnection(Properties.Settings.Default.NorthwindConnectionString))
            {
                // Ouverture de la connexion et début de la transaction
                cnx.Open();
                SqlTransaction tran = cnx.BeginTransaction();

                try
                {
                    // Création et exécution de la commande
                    var command = new SqlCommand(req, cnx, tran);
                    command.Parameters.Add(param);
                    command.ExecuteNonQuery();

                    // Validation de la transaction s'il n'y a pas eu d'erreur
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback(); // Annulation de la transaction en cas d'erreur
                    throw;   // Remontée de l'erreur à l'appelant
                }
            }
        }









        private static DataTable GetDataTableForProd2(List<Produit> list)
        {
            // Créaton d'une table mémoire
            DataTable table = new DataTable();

            // Création des colonnes NomProduit ,CategorieID,QteUnit,Prix,UniteStock et Fournisseur et ajout à la table
            var colId = new DataColumn("ID", typeof(int));
            colId.AllowDBNull = false;
            table.Columns.Add(colId);

            /* Si la colonne de clé primaire n'est pas auto-incrémentée,
            on peut définir une contrainte de clé primaire sur la table
            Ceci affecte automatiquement Unique = True et AllowDBNull = False
            sur la ou les colonne(s) définie(s) comme clé */
            //table.PrimaryKey = new DataColumn[] { col1, col2 };

            // Chargement de la liste des personnes dans la table mémoire
            foreach (var p in list)
            {
                // Création d'une ligne de table
                DataRow ligne = table.NewRow();

                ligne["ID"] = p.Id ;
               


                // Pour une colonne nullable dans la base,
                // il faut affecter la valeur DBNull à la place de null
                //if (p.Catégorie != null)
                //    ligne["CategoryID"] = p.Catégorie;
                //else ligne["CategoryID"] = DBNull.Value;
                //if (p.QtUnit != null)
                //    ligne["QuantityPerUnit"] = p.QtUnit;
                //else ligne["QuantityPerUnit"] = DBNull.Value;
                //if (p.PrixUnit != null)
                //    ligne["UnitPrice"] = p.PrixUnit;
                //else ligne["UnitPrice"] = DBNull.Value;
                //if (p.Unit != null)
                //    ligne["UnitsInStock"] = p.Unit;
                //else ligne["UnitsInStock"] = DBNull.Value;
                //if (p.FournisseurId != null)
                //    ligne["SupplierID"] = p.FournisseurId;
                //else ligne["SupplierID"] = DBNull.Value;

                // Ajout de la ligne dans la table
                table.Rows.Add(ligne);
            }

            return table;
        }









        /// <summary>
        ///  todo recup categories
        /// </summary>
        /// <returns></returns>
        public static List<Categorie> GetCat()
        {
            // Liste de categories pour stocker le résultat de la requête sur table catégories

            List<Categorie> listcat = new List<Categorie>();
            var cat = new Categorie();
            var connectString = Properties.Settings.Default.NorthwindConnectionString;
            string queryString = @"select CategoryID,CategoryName,Description from Categories";

            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);
                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        cat.CategoryID = (int)reader["CategoryID"];
                        cat.CategoryID = (int)reader["CategoryName"];
                        cat.CategoryID = (int)reader["Description"];



                        listcat.Add(cat);
                    }
                }
            }

            return listcat;




        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="list"></param>
        // Insertion d'une liste de personne en base avec requête de masse

        ///////////////////////////////////////////////////////////////////////////////////////////////
        public static void AjouEnMasse(List<Produit> list)
        {

            // Ecriture de la requête d'insertion en masse
            // Le paramètre @table contiendra les enregistrements à insérer
            string req = @"insert Products (ProductName,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,SupplierID)
      select ProductName,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,SupplierID from @table";

            // Création du paramètre de type table mémoire
            // /!\ Le type TypeTableProduit doit être créé au préalable dans la base
            /*
            create type TypeTableProduit as table
              (
              ProductName nvarchar(40),
              CategoryID int,
              QuantityPerUnit nvarchar(20),
              UnitPrice money,
              UnitsInStock smallint,
              SupplierID int
              )

              */

            var param = new SqlParameter("@table", SqlDbType.Structured);
            DataTable tableProd = GetDataTableForProduits(list);
            param.TypeName = "TypeTableProduit";
            param.Value = tableProd;

            using (var cnx = new SqlConnection(Properties.Settings.Default.NorthwindConnectionString))
            {
                // Ouverture de la connexion et début de la transaction
                cnx.Open();
                SqlTransaction tran = cnx.BeginTransaction();

                try
                {
                    // Création et exécution de la commande
                    var command = new SqlCommand(req, cnx, tran);
                    command.Parameters.Add(param);
                    command.ExecuteNonQuery();

                    // Validation de la transaction s'il n'y a pas eu d'erreur
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback(); // Annulation de la transaction en cas d'erreur
                    throw;   // Remontée de l'erreur à l'appelant
                }
            }
        }

        // Création et remplissage d'une table mémoire à partir d'une liste de produitss
        private static DataTable GetDataTableForProduits(List<Produit> listProd)
        {
            // Créaton d'une table mémoire
            DataTable table = new DataTable();

            // Création des colonnes NomProduit ,CategorieID,QteUnit,Prix,UniteStock et Fournisseur et ajout à la table
            var colNomProd = new DataColumn("ProductName", typeof(string));
            colNomProd.AllowDBNull = false;
            table.Columns.Add(colNomProd);

            var colCatId = new DataColumn("CategoryID", typeof(int));
            colCatId.AllowDBNull = false;
            table.Columns.Add(colCatId);

            var colQtU = new DataColumn("QuantityPerUnit", typeof(string));
            colQtU.AllowDBNull = false;
            table.Columns.Add(colQtU);

            var colPrix = new DataColumn("UnitPrice", typeof(int));
            colPrix.AllowDBNull = false;
            table.Columns.Add(colPrix);

            var colUnitenStock = new DataColumn("UnitsInStock", typeof(string));
            colUnitenStock.AllowDBNull = false;
            table.Columns.Add(colUnitenStock);

            var colFour = new DataColumn("SupplierID", typeof(int));
            colFour.AllowDBNull = false;
            table.Columns.Add(colFour);

            // Pour les colonnes nullables, on peut utiliser une syntaxe plus courte
            // car AllowDBNull à la valeur True par défaut
            //table.Columns.Add(new DataColumn("Titre", typeof(string)));

            /* Si la colonne de clé primaire n'est pas auto-incrémentée,
            on peut définir une contrainte de clé primaire sur la table
            Ceci affecte automatiquement Unique = True et AllowDBNull = False
            sur la ou les colonne(s) définie(s) comme clé */
            //table.PrimaryKey = new DataColumn[] { col1, col2 };

            // Chargement de la liste des personnes dans la table mémoire
            foreach (var p in listProd)
            {
                // Création d'une ligne de table
                DataRow ligne = table.NewRow();

                ligne["ProductName"] = p.Nom;
                ligne["CategoryID"] = p.Catégorie;
                ligne["QuantityPerUnit"] = p.QtUnit;
                ligne["UnitPrice"] = p.PrixUnit;
                ligne["UnitsInStock"] = p.Unit;
                ligne["SupplierID"] = p.FournisseurId;



                // Pour une colonne nullable dans la base,
                // il faut affecter la valeur DBNull à la place de null
                if (p.Catégorie != null)
                    ligne["CategoryID"] = p.Catégorie;
                else ligne["CategoryID"] = DBNull.Value;
                if (p.QtUnit != null)
                    ligne["QuantityPerUnit"] = p.QtUnit;
                else ligne["QuantityPerUnit"] = DBNull.Value;
                if (p.PrixUnit != null)
                    ligne["UnitPrice"] = p.PrixUnit;
                else ligne["UnitPrice"] = DBNull.Value;
                if (p.Unit != null)
                    ligne["UnitsInStock"] = p.Unit;
                else ligne["UnitsInStock"] = DBNull.Value;
                if (p.FournisseurId != null)
                    ligne["SupplierID"] = p.FournisseurId;
                else ligne["SupplierID"] = DBNull.Value;

                // Ajout de la ligne dans la table
                table.Rows.Add(ligne);
            }

            return table;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///// <summary>
        ///// Suppression de masse par mise à 1 du champ discounted de la table Products
        ///// </summary>
        ///// <param name="listId"></param>
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //public static void SuppEnMasse(List<int> listId)
        //{

        //    // Ecriture de la requête d'insertion en masse
        //    // Le paramètre @table contiendra les enregistrements à insérer
        //    string req = @"update Products set Discontinued=1 
        //                   from @table t 
        //                    inner join Products p on t.Id = p.ProductID";



        //    var param = new SqlParameter("@table", SqlDbType.Structured);
        //    DataTable tableProd = GetDataTableForProd(listId);
        //    param.TypeName = "TypeTabId";
        //    param.Value = tableProd;

        //    using (var cnx = new SqlConnection(Properties.Settings.Default.NorthwindConnectionString))
        //    {
        //        // Ouverture de la connexion et début de la transaction
        //        cnx.Open();
        //        SqlTransaction tran = cnx.BeginTransaction();

        //        try
        //        {
        //            // Création et exécution de la commande
        //            var command = new SqlCommand(req, cnx, tran);
        //            command.Parameters.Add(param);
        //            command.ExecuteNonQuery();

        //            // Validation de la transaction s'il n'y a pas eu d'erreur
        //            tran.Commit();
        //        }
        //        catch (Exception)
        //        {
        //            tran.Rollback(); // Annulation de la transaction en cas d'erreur
        //            throw;   // Remontée de l'erreur à l'appelant
        //        }
        //    }
        //}


        //private static DataTable GetDataTableForProd(List<int> list)
        //{
        //    // Créaton d'une table mémoire
        //    DataTable table = new DataTable();

        //    // Création des colonnes NomProduit ,CategorieID,QteUnit,Prix,UniteStock et Fournisseur et ajout à la table
        //    var colId = new DataColumn("ID", typeof(int));
        //    colId.AllowDBNull = false;
        //    table.Columns.Add(colId);

        //    // Chargement de la liste des personnes dans la table mémoire
        //    foreach (var p in list)
        //    {
        //        // Création d'une ligne de table
        //        DataRow ligne = table.NewRow();

        //        ligne["ID"] = p;

        //        table.Rows.Add(ligne);
        //    }

        //    return table;
        //}

    }
}







