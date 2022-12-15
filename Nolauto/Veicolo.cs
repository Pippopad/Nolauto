using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nolauto
{
    public abstract class Veicolo
    {
        public string Targa { get; set; }
        public string Modello { get; set; }
        public double Tariffa { get; set; }

        public Veicolo(string targa, string modello, double tariffa)
        {
            this.Targa = targa;
            this.Modello = modello;
            this.Tariffa = tariffa;
        }
    }
}
