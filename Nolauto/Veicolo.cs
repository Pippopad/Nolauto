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
        public string Targa { get; set; }
        public string Marca { get; set; }
        public double Tariffa { get; set; }
        public double Kilowatt { get; }

        public Veicolo(string targa, string marca, double tariffa, double kilowatt)
        {
            this.Targa = targa;
            this.Marca = marca;
            this.Tariffa = tariffa;
            this.Kilowatt = kilowatt;
        }
    }
}
