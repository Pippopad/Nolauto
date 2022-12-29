using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nolauto
{
    public class GestoreNoleggi
    {
        private static List<Noleggio> Noleggi;

        public static void Inizializza()
        {
            Noleggi = new List<Noleggio>();
        }

        public static Noleggio AggiungiNoleggio(DateTime dataInizio, int numeroGiorni, double costo, Cliente cliente, Veicolo veicolo)
        {
            Noleggio found = Noleggi.Find((noleggio) => dataInizio <= noleggio.DataInizio.AddDays(noleggio.NumeroGiorni - 1) && veicolo.Targa == noleggio.Veicolo.Targa);
            if (found != null) return found;

            Noleggi.Add(new Noleggio(dataInizio, numeroGiorni, costo, cliente, veicolo));
            return null;
        }

        public static bool RimuoviNoleggio(Noleggio n)
        {
            return RimuoviNoleggio(n.Id);
        }

        public static bool RimuoviNoleggio(int id)
        {
            Noleggio found = Noleggi.Find((noleggio) => noleggio.Id == id);
            if (found == null) return false;

            Noleggi.Remove(found);
            return true;
        }

        public static List<Noleggio> GetAll()
        {
            return Noleggi;
        }

        public static Noleggio GetById(int id)
        {
            return Noleggi.Find((noleggio) => noleggio.Id == id);
        }

        public static List<Noleggio> GetByVeicolo(Veicolo v)
        {
            return GetByTarga(v.Targa);
        }

        public static List<Noleggio> GetByTarga(string targa)
        {
            return Noleggi.FindAll((noleggio) => noleggio.Veicolo.Targa == targa);
        }

        public static List<Noleggio> GetByCliente(Cliente c)
        {
            return GetByCodiceFiscale(c.CodiceFiscale);
        }

        public static List<Noleggio> GetByCodiceFiscale(string codiceFiscale)
        {
            return Noleggi.FindAll((noleggio) => noleggio.Cliente.CodiceFiscale == codiceFiscale);
        }
    }
}
