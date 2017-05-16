using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public static class DALTache
    {
        ////////////////////////////////////////////////////////////////////////
             ///récupération des personnes de l'équipe Dev Bio humaine
       /////////////////////////////////////////////////////////////////////////
        public static List<Personne> GetPers()
        {
            List<Personne> listPers = new List<Personne>();

            var connectString = Properties.Settings.Default.ProjetWinformsConnection;
            string queryString = @"select * from jo.Personne p
                                inner join jo.Equipe e on p.CodeEquipe=e.CodeEquipe where e.Nom='Dev Bio humaine'";
                    
            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);

                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetPersonneFromDataReader(listPers, reader);
                    }
                }
            }

            return listPers;


        }
        private static void GetPersonneFromDataReader(List<Personne> listCom, SqlDataReader reader)
        {

           
            var pers = new Personne();

                pers.Login = (string)reader["Login"];
            
                pers.Nom = (string)reader["Nom"];
            
                pers.Prenom = (string)reader["Prenom"];
           
                pers.CodeEquipe = (string)reader["CodeEquipe"];
            
                pers.CodeMetier = (string)reader["CodeMetier"];
                            
            if (reader["Manager"] != DBNull.Value)
                pers.Manager = (string)reader["Manager"];
            
                pers.TauxProductivite = (float)reader["TauxProductivite"];
            
            listCom.Add(pers);

        }

        ////////////////////////////////////////////////////////////////////////
        ///récupération des taches de l'équipe Dev Bio humaine
        /////////////////////////////////////////////////////////////////////////
        public static BindingList<Tache> GetTache()
        {
            BindingList<Tache> listTache = new BindingList<Tache>();

            var connectString = Properties.Settings.Default.ProjetWinformsConnection;
            string queryString = @"select t.Libelle,t.Annexe,t.CodeActivite,t.Login,t.Description,tp.Numero,tp.DureePrevue,tp.DureeRestanteEstimee,
			                	tp.CodeModule,tp.CodeLogicieModule,tp.NumeroVersion,tp.CodeLogicielVersion
                                from jo.Tache t
                                left outer join jo.TacheProd tp on t.IdTache=tp.IdTache
                                inner join jo.Personne p on t.Login=p.Login
                                inner join jo.Equipe e on p.CodeEquipe=e.CodeEquipe
                                where e.Nom='Dev Bio humaine'";

            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);

                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetTacheFromDataReader(listTache, reader);
                    }
                }
            }

            return listTache;
        }

                   private static void GetTacheFromDataReader(BindingList<Tache> listTache, SqlDataReader reader)
        {

            //todo controle valeurs null à finir
            var tach = new Tache();


            if (reader["Libelle"] != DBNull.Value)
                tach.Libelle = (string)reader["Libelle"];
            if (reader["Annexe"] != DBNull.Value)
                tach.Annexe = (bool)reader["Annexe"];
            if (reader["CodeActivite"] != DBNull.Value)
                tach.CodeActivite = (string)reader["CodeActivite"];
            if (reader["Login"] != DBNull.Value)
                tach.Login = (string)reader["Login"];                       
                tach.Description = (string)reader["Description"];
            if (reader["Numero"] != DBNull.Value)
                tach.Numero = (int)reader["Numero"];
            if (reader["DureePrevue"] != DBNull.Value)
                tach.DureePrevue = (float)reader["DureePrevue"];

            if (reader["DureeRestanteEstimee"] != DBNull.Value)
                tach.DureeRestanteEstimee = (float)reader["DureeRestanteEstimee"];

            if (reader["CodeModule"] != DBNull.Value)
                tach.CodeModule = (string)reader["CodeModule"];

            if (reader["CodeLogicieModule"] != DBNull.Value)
                tach.CodeLogicieModule = (string)reader["CodeLogicieModule"];

            if (reader["NumeroVersion"] != DBNull.Value)
                tach.NumeroVersion = (float)reader["NumeroVersion"];

            if (reader["CodeLogicielVersion"] != DBNull.Value)
                tach.CodeLogicielVersion = (string)reader["CodeLogicielVersion"];


            listTache.Add(tach);

        }







    }
}
