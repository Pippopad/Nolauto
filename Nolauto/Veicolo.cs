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

        private List<Noleggio> Noleggi;

        public Veicolo(string targa, string marca, double tariffa, double kilowatt)
        {
            this.Targa = targa;
            this.Marca = marca;
            this.Tariffa = tariffa;
            this.Kilowatt = kilowatt;

            this.Noleggi = new List<Noleggio>();
        }

        public bool AggiungiNoleggio(Noleggio n)
        {
            if (Noleggi.Find((noleggio) => noleggio.Id == n.Id) != null) return false;

            // TODO: Controllo collisione date

            Noleggi.Add(n);
            return true;
        }

        public bool RimuoviNoleggio(Noleggio n)
        {
            return RimuoviNoleggio(n.Id);
        }

        public bool RimuoviNoleggio(int id)
        {
            Noleggio found = Noleggi.Find((noleggio) => noleggio.Id == id);
            if (found == null) return false;

            Noleggi.Remove(found);
            return true;
        }

        public List<Noleggio> GetAll()
        {
            return Noleggi;
        }

        public Noleggio Get(int id)
        {
            return Noleggi.Find((noleggio) => noleggio.Id == id);
        }
    }
}
