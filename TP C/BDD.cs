using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace TP_C
{
  internal static  class  BDD
    {

        private static string connectionString = "server=localhost;database=c#;uid=root;pwd=;"; 
        private static MySqlConnection connection = null;


        public static  MySqlConnection GetConnection()
        {
            return connection;
        }

        // Méthode pour obtenir la connexion à la base de données
        public static MySqlConnection CreateConnection() 
        {
            
            
          if (connection == null) 
           { connection = new MySqlConnection(connectionString); }
    
            return connection;
        }

        // Méthode pour ouvrir la connexion
        public static void OpenConnection()
        {
            if (connection == null)
                connection = CreateConnection();
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }



        // Méthode pour fermer la connexion
        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }


        // Méthode pour exécuter une requête SQL (Insert, Update, Delete)
        public static int ExecuteQuery(string query)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result;
        }

        internal static bool InsertUser(string text1, string text2, string text3, string text4)
        {
            throw new NotImplementedException();
        }

        // Méthode pour exécuter une requête SQL de sélection (Select)
        public static MySqlDataReader ExecuteSelect(string query)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            return cmd.ExecuteReader();
        }
       public static bool InsertUser( User user) {
            try
            {
                string insertQuery = "INSERT INTO user (nom, prenom, pseudo, password) VALUES (@nom, @prenom, @pseudo, @password)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@nom", user.Nom);
                    cmd.Parameters.AddWithValue("@prenom", user.Prenom);
                    cmd.Parameters.AddWithValue("@pseudo", user.Pseudo);
                    cmd.Parameters.AddWithValue("@password", user.Mdp);

                    OpenConnection();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    CloseConnection();

                    return rowsAffected == 1;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
            




    }


}
