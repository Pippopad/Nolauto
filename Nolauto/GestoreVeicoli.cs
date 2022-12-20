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
        private static ListView View;

        public static void Inizializza(ListView view)
        {
            Veicoli = new List<Veicolo>();
            View = view;
        }

        public static bool AggiungiVeicolo(Veicolo v)
        {
            if (Veicoli.Find((veicolo) => veicolo.Targa == v.Targa) != null) return false;

            Veicoli.Add(v);
            UpdateView();
            return true;
        }

        public static bool RimuoviVeicolo(Veicolo v)
        {
            return RimuoviVeicolo(v.Targa);
        }

        public static bool RimuoviVeicolo(string targa)
        {
            Veicolo found = Veicoli.Find((veicolo) => veicolo.Targa == targa);
            if (found == null) return false;

            Veicoli.Remove(found);
            UpdateView();
            return true;
        }

        public static List<Veicolo> GetAll()
        {
            return Veicoli;
        }

        public static Veicolo Get(string targa)
        {
            return Veicoli.Find((veicolo) => veicolo.Targa == targa);
        }

        public static void UpdateView()
        {
            View.Items.Clear();
            foreach (Veicolo v in Veicoli)
            {
                ListViewItem item = new ListViewItem(v.Targa);
                item.SubItems.Add(v.Marca);
                item.SubItems.Add(v.Tariffa.ToString());
                item.SubItems.Add(v.Kilowatt.ToString());

                if (v is Automobile)
                {
                    item.SubItems.Add((v as Automobile).NumeroPosti.ToString());
                    item.SubItems.Add(nameof(Automobile));
                }
                if (v is Furgone)
                {
                    item.SubItems.Add((v as Furgone).CapacitaDiCarico.ToString());
                    item.SubItems.Add(nameof(Furgone));
                }

                View.Items.Add(item);
            }
        }
    }
}
