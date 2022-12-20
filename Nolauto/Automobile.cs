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

        public Automobile(string targa, string marca, double tariffa, double kilowatt, int numeroPosti) : base(targa, marca, tariffa, kilowatt)
        {
            this.NumeroPosti = numeroPosti;
        }
    }
}
