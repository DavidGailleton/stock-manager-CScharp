using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class Ordonnance
    {
        public int id { get; }
        public String Posologie { get; set; }
        public int Duree { get; set; }
        public String Instruction { get; set; }
        public Patient Patient { get; set; }
        public Medicament Medicament { get; set; }
        public Medecin Medecin { get; set; }

        public Ordonnance(int id, String Posologie, int Duree, String Instruction, Patient patient, Medicament medicament, Medecin medecin)
        {
            this.id = id;
            this.Posologie = Posologie;
            this.Duree = Duree;
            this.Instruction = Instruction;
            this.Patient = patient;
            this.Medicament = medicament;
            this.Medecin = medecin;
            
        }
    }
}
