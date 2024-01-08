using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    

    internal class Patient
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Naissance { get; set; }
        public string sexe { get; set; }

        public Patient(string Nom, string Prenom, DateTime Naissance, string sexe)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Naissance = Naissance;
            this.sexe = sexe;
        }
    }
}
