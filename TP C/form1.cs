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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=c#;uid=donavan;pwd=dodo;");
        string server = "localhost";
        string uid = "donavan";
        string password = "dodo";
        string database = "c#";




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Tbuser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {  
            
            // Récupération des valeurs des TextBox
            string pseudo = textPseudo.Text;
            string password = Textmdp.Text;

            // Création de la requête SQL
            string query = $"select * from   user where  pseudo   = '{pseudo}' and password = '{password}'";


            String conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();
            var reader  = cmd.ExecuteReader();


            var succes = reader.HasRows;
            if (succes)
            {
                var tableau = new tableau();
                tableau.Show();
                this.Hide();


            }
            else {
                MessageBox.Show("ya une erreur");
                    
                    
                    }


              



        }

        private void mdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
