using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace TP_C

{
    class Equipement
    {
        private int Id;
        private string nom;
        private bool Disponible;


        public Equipement(int id, string nom, bool Disponible)
        {
            this.Id = id;
            this.nom = nom;
            Disponible = Disponible;
        }


        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            this.Id = id;
        }


        public string GetNom()
        {
            return nom;
        }

        public void SetNom(string nom)
        {
            this.nom = nom;
        }

        public bool IsDisponible()
        {
            return Disponible;
        }

        public override string ToString()
        {
            return nom; // Cela permet d'afficher uniquement le nom dans la ComboBox
        }

        public static List<Equipement> GetEquipementsDisponibles()
        {
            List<Equipement> equipements = new List<Equipement>();
            using (MySqlConnection conn = BDD.GetConnection())
            {
                if(conn == null)
                {
                    Console.WriteLine("Erreur :connextion Mysql est null !");
                }

                try
                {
                    conn.Open();
                    string query = "SELECT id, nom, disponible FROM Equipement WHERE disponible = 1;";
                    MySqlCommand cmd = new MySqlCommand(query, conn) ;
                   MySqlDataReader reader = cmd.ExecuteReader() ;

                    while (reader.Read())
                    {
                        equipements.Add(new Equipement(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.GetBoolean("disponible")
                        ));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de la récupération des équipements : " + ex.Message);
                }
            }
            return equipements;
        }




    }
}
