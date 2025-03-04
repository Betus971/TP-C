using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_C
{
    public partial class Inscription : Form

    {

        public Inscription()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Vérification que les champs ne sont pas vides
            if (string.IsNullOrWhiteSpace(textNom.Text) ||
                string.IsNullOrWhiteSpace(textPrenom.Text) ||
                string.IsNullOrWhiteSpace(textpseudo.Text) ||
                string.IsNullOrWhiteSpace(textmdp.Text))
            {
                // Message d'erreur si un champ est vide
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            // Création d'un nouvel objet User avec les informations saisies
            User nouvelUtilisateur = new User(textNom.Text, textPrenom.Text, textpseudo.Text, textmdp.Text);

            // Appel de la méthode InsertUser avec l'objet User
            bool success = BDD.InsertUser(nouvelUtilisateur);

            // Affichage du résultat
            if (success)
            {
                MessageBox.Show("Insertion réussie");
            }
            else
            {
                MessageBox.Show("Erreur lors de l'insertion.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void labellogin_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();
             
                }
    }
}
