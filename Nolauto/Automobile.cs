using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nolauto
{
    public class Automobile : Veicolo
    {
        public override TipoVeicolo __tipo__ => TipoVeicolo.Automobile;

        public int NumeroPosti { get; set; }
    }
}
