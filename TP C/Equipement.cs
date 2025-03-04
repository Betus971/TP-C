using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C

{
    class Equipement
    {
        private int Id;
        private string nom;
        private bool isDisponible;


        public Equipement(int id, string nom, bool isDisponible)
        {
            this.Id = id;
            this.nom = nom;
            this.isDisponible = isDisponible;
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
            return isDisponible;
        }

        
    }
}
