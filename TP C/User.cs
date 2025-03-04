using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C
{
    class User
    {

        private string nom;
        private string prenom;
        private string pseudo;
        private string mdp;


        public User(string nom, string prenom, string pseudo, string mdp)

        {
            this.nom = nom;
            this.prenom = prenom;
            this.pseudo = pseudo;
            this.mdp = mdp;

        }

        // Propriétés publiques pour accéder aux champs privés
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }

        public string Mdp
        {
            get { return mdp; }
            set { mdp = value; }
        }

    }

}


  
