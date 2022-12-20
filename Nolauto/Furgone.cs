using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nolauto
{
    public class Furgone : Veicolo
    {
        public double CapacitaDiCarico { get; set; }

        public Furgone(string targa, string marca, double tariffa, double kilowatt, double capacitaDiCarico) : base(targa, marca, tariffa, kilowatt)
        {
            this.CapacitaDiCarico = capacitaDiCarico;
        }
    }
}
