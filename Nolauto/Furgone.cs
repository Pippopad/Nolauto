using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nolauto
{
    public class Furgone : Veicolo
    {
        public override TipoVeicolo __tipo__ => TipoVeicolo.Furgone;

        public double CapacitaDiCarico { get; set; }
    }
}
