using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C
{
    class Categorie
    {
        public int Id;
        public string Nom;

        public Categorie(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        public override string ToString()
        {
            return $"Categorie [id={Id},Nom={Nom}]";
        }

    }
}
