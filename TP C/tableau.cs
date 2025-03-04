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

    public partial class tableau : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=c#;uid=donavan;pwd=dodo;");
        string server = "localhost";
        string uid="donavan";
        string password = "dodo";
        string database = "c#";


        public tableau()
        {
            InitializeComponent();
        }

        private void Formulaire_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void afficher_Click(object sender, EventArgs e)
        {
          //  MySqlCommand cmd = new MySqlCommand("Select id_user,Nom from user", connection);
           // cmd.Parameters.AddWithValue("id_user", textBox1.Text);
            // MySqlDataAdapter da = new MySqlDataAdapter();
            // da.SelectCommand = cmd;
           // DataTable dt = new DataTable();
           // dt.Clear();
           //  da.Fill(dt);
           // dataGridView1.DataSource = dt;
           // dataGridView1.AllowUserToAddRows = false;
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            //UPDATE `contact_table` SET `id`= '[value-1]',`nom`= '[value-2]',`prenom`= '[value-3]',`email`= '[value-4]' WHERE 1
            string createtable = "update contact_table set 'id'('" + textBoxNom.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "')";

            for (int item = 0; item <= dataGridView1.Rows.Count - 1; item++)
            {
                MySqlCommand cmd2 = new MySqlCommand("Update user set Nom=@Nom,");




            }



        }

        private void update_Click(object sender, EventArgs e)
        {
            String conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string createtable = "insert into contact_table (nom,prenom,email) values('"+ textBoxNom.Text+"', '"+textBox3.Text+"','"+textBox4.Text+"')";
            MySqlCommand cmd = new MySqlCommand(createtable, con);
           int i = cmd.ExecuteNonQuery();
            MessageBox.Show("inseré avec succse");

        }

        private void crée_table_Click(object sender, EventArgs e)
        {
            String conString="server="+server+ ";uid=" + uid +";pwd=" +password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string createtable = "create table contact_table (id int,nom varchar(50),prenom varchar (50), email varchar (50))";
            MySqlCommand cmd = new MySqlCommand(createtable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("table crée");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string createtable = "select * from contact_table ";
            MySqlCommand cmd = new MySqlCommand(createtable, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

        }

        private void update1_Click(object sender, EventArgs e)
        {
            String conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string updateQuery = "Update contact_table SET nom='" + textBoxNom.Text + "', prenom='" + textBox3.Text + "',email='" + textBox4.Text + "' where id ="+int.Parse(textBoxID.Text);
            MySqlCommand cmd = new MySqlCommand(updateQuery, con);
             int i = cmd.ExecuteNonQuery();
            MessageBox.Show("inseré avec succse");


        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //dataGridView1.CurrentRow.Selected =  true;
                textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                textBoxNom.Text = dataGridView1.Rows[e.RowIndex].Cells["nom"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["prenom"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            String conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string deleteQuery = "DELETE from contact_table  where id =" + int.Parse(textBoxID.Text);
            MySqlCommand cmd = new MySqlCommand(deleteQuery, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("Supprimer avec succse");

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     

        private void afficherLaTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("Select id_user,Nom from user", connection);
            cmd.Parameters.AddWithValue("id_user", textBox1.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
