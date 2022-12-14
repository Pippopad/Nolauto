using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nolauto
{
    public static class GestoreVeicoli
    {
        private static List<Veicolo> Veicoli;

        public static void Inizializza()
        {
            Inizializza(new List<Veicolo>());
        }

        public static void Inizializza(List<Veicolo> veicoli)
        {
            Veicoli = veicoli;
        }

        public static bool AggiungiVeicolo(Veicolo v)
        {
            if (Veicoli.Find((veicolo) => veicolo.Targa == v.Targa) != null) return false;

            v.Targa = v.Targa.ToUpper();
            Veicoli.Add(v);
            return true;
        }

        public static bool RimuoviVeicolo(Veicolo v)
        {
            return RimuoviVeicolo(v.Targa);
        }

        public static bool RimuoviVeicolo(string targa)
        {
            Veicolo found = Veicoli.Find((veicolo) => veicolo.Targa == targa.ToUpper());
            if (found == null) return false;

            Veicoli.Remove(found);
            return true;
        }

        public static List<Veicolo> GetAll()
        {
            return Veicoli;
        }

        public static Veicolo Get(string targa)
        {
            return Veicoli.Find((veicolo) => veicolo.Targa == targa.ToUpper());
        }
    }
}
