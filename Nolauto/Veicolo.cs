using System;
using System.Collections.Generic;
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

    public abstract class Veicolo
    {
        public string Targa { get; }
        public string Marca { get; }
        public double Tariffa { get; }
        public double Kilowatt { get; }

        public Veicolo(string targa, string marca, double tariffa, double kilowatt)
        {
            this.Targa = targa.ToUpper();
            this.Marca = marca;
            this.Tariffa = tariffa;
            this.Kilowatt = kilowatt;
        }

        public override string ToString()
        {
            return $"{this.Marca} ({this.Targa})";
        }
    }
}
