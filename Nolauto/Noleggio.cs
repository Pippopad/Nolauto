using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nolauto
{
    public class Noleggio
    {
        private static int ID_COUNTER = 0;

        public int Id { get; set; }
        public DateTime DataInizio { get; set; }
        public int NumeroGiorni { get; set; }
        public double Costo { get; set; }
        public Cliente Cliente { get; set; }
        public Veicolo Veicolo { get; set; }

        public Noleggio()
        {
            this.Id = ID_COUNTER++;
        }

        public override string ToString()
        {
            return $"ID: {this.Id}\r\t\tTarga: {this.Veicolo.Targa}\r\t\t\t\t\tCliente: {this.Cliente.CodiceFiscale}";
        }
    }
}
