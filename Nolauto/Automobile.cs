using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nolauto
{
    public class Automobile : Veicolo
    {
        public int NumeroPosti { get; set; }

        public Automobile(string targa, string modello, double tariffa, double kilowatt, int numeroPosti) : base(targa, modello, tariffa, kilowatt)
        {
            this.NumeroPosti = numeroPosti;
        }
    }
}
