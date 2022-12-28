using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nolauto
{
    public static class GestoreClienti
    {
        private static List<Cliente> Clienti;

        public static void Inizializza()
        {
            Clienti = new List<Cliente>();
        }

        public static bool AggiungiCliente(Cliente c)
        {
            if (Clienti.Find((cliente) => cliente.CodiceFiscale == c.CodiceFiscale) != null) return false;

            Clienti.Add(c);
            return true;
        }

        public static bool RimuoviCliente(Cliente c)
        {
            return RimuoviCliente(c.CodiceFiscale);
        }

        public static bool RimuoviCliente(string codiceFiscale)
        {
            Cliente found = Clienti.Find((cliente) => cliente.CodiceFiscale == codiceFiscale.ToUpper());
            if (found == null) return false;

            Clienti.Remove(found);
            return true;
        }

        public static List<Cliente> GetAll()
        {
            return Clienti;
        }

        public static Cliente Get(string codiceFiscale)
        {
            return Clienti.Find((cliente) => cliente.CodiceFiscale == codiceFiscale.ToUpper());
        }
    }
}
