using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class Medecin
    {
        public int id { get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Naissance { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Medecin(int id, string Nom, string Prenom, DateTime Naissance, string Login, string Password)
        {
            this.id = id;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Naissance = Naissance;
            this.Login = Login;
            this.Password = Password;
        }
    }
}
