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
            Inizializza(new List<Noleggio>());
        }

        public static void Inizializza(List<Noleggio> noleggi)
        {
            Noleggi = noleggi;
        }

        public static Noleggio AggiungiNoleggio(DateTime dataInizio, int numeroGiorni, double costo, Cliente cliente, Veicolo veicolo)
        {
            Noleggio found = Noleggi.Find((noleggio) => veicolo.Targa == noleggio.Veicolo.Targa && ((dataInizio >= noleggio.DataInizio && dataInizio <= noleggio.DataInizio.AddDays(noleggio.NumeroGiorni - 1)) || (dataInizio < noleggio.DataInizio && dataInizio.AddDays(numeroGiorni - 1) >= noleggio.DataInizio)));
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
            return GetByVeicolo(v.Targa);
        }

        public static List<Noleggio> GetByVeicolo(string targa)
        {
            return Noleggi.FindAll((noleggio) => noleggio.Veicolo.Targa == targa);
        }

        public static List<Noleggio> GetByCliente(Cliente c)
        {
            return GetByCliente(c.CodiceFiscale);
        }

        public static List<Noleggio> GetByCliente(string codiceFiscale)
        {
            return Noleggi.FindAll((noleggio) => noleggio.Cliente.CodiceFiscale == codiceFiscale);
        }
    }
}
