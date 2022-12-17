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

        public int Id { get; }
        public DateTime DataInizio { get; set; }
        public int NumeroGiorni { get; set; }
        public double Costo { get; set; }
        public Cliente Cliente { get; }

        public Noleggio(DateTime dataInizio, int numeroGiorni, double costo, Cliente cliente)
        {
            this.Id = ID_COUNTER++;

            this.DataInizio = dataInizio;
            this.NumeroGiorni = numeroGiorni;
            this.Costo = costo;
            this.Cliente = cliente;
        }
    }
}
