using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class Medicament
    {
        public string Libelle { get; set; }
        public string Contre_indication { get; set; }

        public Medicament (string Libelle, string Contre_indication)
        {
            this.Libelle = Libelle;
            this.Contre_indication = Contre_indication;
        }
    }
}
