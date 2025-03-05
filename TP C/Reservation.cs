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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        public void ChargerEquipement()
        {
            SelectEquipement.Items.Clear();
            List<Equipement> equipements = Equipement.GetEquipementsDisponibles();
            foreach( var equipement in equipements)
            {
                SelectEquipement.Items.Add(equipement);
            }

        }

        private void equipement_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            Console.WriteLine("🟢 Chargement des équipements...");

            ChargerEquipement();
        }

     

        private void ButtonReserver_Click(object sender, EventArgs e)
        {
            if (SelectEquipement.SelectedItem is Equipement selectedEquipement)
            {
                // Récupérez les informations nécessaires (utilisateur, dates, etc.)
                // Enregistrez la réservation dans la base de données
                MessageBox.Show($"Réservation de {selectedEquipement.GetNom} effectuée avec succès!");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un équipement.");
            }
        }

        private void SelectEquipement_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(value: $"Équipement sélectionné: {SelectEquipement.SetNom}");
        }
    }
}
