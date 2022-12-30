using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nolauto
{
    public enum TipoVeicolo
    {
        Automobile,
        Furgone,
    }

    [JsonConverter(typeof(BaseClassConverter))]
    public abstract class Veicolo
    {
        public abstract TipoVeicolo __tipo__ { get; }

        public string Targa { get; set; }
        public string Marca { get; set; }
        public double Tariffa { get; set; }
        public double Kilowatt { get; set; }

        public override string ToString()
        {
            return $"{this.Marca} ({this.Targa})";
        }
    }
}
