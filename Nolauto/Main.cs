using Nolauto.DialogBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nolauto
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            GestoreVeicoli.Inizializza();
            GestoreClienti.Inizializza();
            GestoreNoleggi.Inizializza();
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestoreVeicoli.Inizializza();
            GestoreClienti.Inizializza();
            GestoreNoleggi.Inizializza();

            UpdateView();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aggiungiVeicoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoVeicolo tipo = sender == automobileToolStripMenuItem ? TipoVeicolo.Automobile : TipoVeicolo.Furgone;

            using (var avDialog = new AggiungiVeicoloDialog())
            {
                avDialog.Tipo = tipo;
                avDialog.ShowDialog();
                UpdateView();
            }
        }

        private void rimuoviVeicoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string targa = (sender as ToolStripMenuItem).Name;

            if (GestoreVeicoli.RimuoviVeicolo(targa))
            {
                foreach (Noleggio n in GestoreNoleggi.GetByVeicolo(targa))
                    GestoreNoleggi.RimuoviNoleggio(n);
            }
            UpdateView();
        }

        private void aggiungiNoleggioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var anDialog = new AggiungiNoleggioDialog())
            {
                anDialog.ShowDialog();
                UpdateView();
            }
        }

        private void rimuoviNoleggioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as ToolStripMenuItem).Name);

            GestoreNoleggi.RimuoviNoleggio(id);
            UpdateMenu();
            UpdateNoleggiListView();
        }

        private void aggiungiClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var acDialog = new AggiungiClienteDialog())
            {
                acDialog.ShowDialog();
                UpdateView();
            }
        }

        private void rimuoviClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codiceFiscale = (sender as ToolStripMenuItem).Name;

            if (GestoreClienti.RimuoviCliente(codiceFiscale))
            {
                foreach (Noleggio n in GestoreNoleggi.GetByCliente(codiceFiscale))
                    GestoreNoleggi.RimuoviNoleggio(n);
            }

            UpdateView();
        }

        private void lstVeicoli_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateNoleggiListView();
        }

        private void UpdateView()
        {
            UpdateVeicoliListView();
            UpdateNoleggiListView();
            UpdateMenu();
        }

        private void UpdateVeicoliListView()
        {
            int selected = lstVeicoli.SelectedIndices.Count > 0 ? lstVeicoli.SelectedIndices[0] : -1;
            string targa = selected != -1 ? lstVeicoli.SelectedItems[0].Text : null;

            lstVeicoli.Items.Clear();
            foreach (Veicolo v in GestoreVeicoli.GetAll())
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

                lstVeicoli.Items.Add(item);
            }

            if (selected != -1)
            {
                int idx = 0;
                foreach (ListViewItem item in lstVeicoli.Items)
                {
                    if (item.Text == targa)
                    {
                        lstVeicoli.SelectedIndices.Add(idx);
                        break;
                    }
                    idx++;
                }
            }
        }

        private void UpdateNoleggiListView()
        {
            lstNoleggi.Items.Clear();
            if (lstVeicoli.SelectedItems.Count > 0)
            {
                foreach (Noleggio n in GestoreNoleggi.GetByVeicolo(lstVeicoli.SelectedItems[0].Text))
                {
                    ListViewItem item = new ListViewItem(n.Id.ToString());
                    item.SubItems.Add(n.DataInizio.ToShortDateString());
                    item.SubItems.Add(n.NumeroGiorni.ToString());
                    item.SubItems.Add(n.Costo.ToString());
                    item.SubItems.Add(n.Cliente.ToString());
                    lstNoleggi.Items.Add(item);
                }
            }
        }

        private void UpdateMenu()
        {
            rimuoviVeicoloToolStripMenuItem.DropDownItems.Clear();
            foreach (Veicolo v in GestoreVeicoli.GetAll())
            {
                ToolStripMenuItem item = new ToolStripMenuItem(v.ToString());
                item.Name = v.Targa;
                item.Click += rimuoviVeicoloToolStripMenuItem_Click;
                rimuoviVeicoloToolStripMenuItem.DropDownItems.Add(item);
            }

            rimuoviClienteToolStripMenuItem.DropDownItems.Clear();
            foreach (Cliente c in GestoreClienti.GetAll())
            {
                ToolStripMenuItem item = new ToolStripMenuItem(c.ToString());
                item.Name = c.CodiceFiscale;
                item.Click += rimuoviClienteToolStripMenuItem_Click;
                rimuoviClienteToolStripMenuItem.DropDownItems.Add(item);
            }

            rimuoviNoleggioToolStripMenuItem.DropDownItems.Clear();
            foreach (Noleggio n in GestoreNoleggi.GetAll())
            {
                ToolStripMenuItem item = new ToolStripMenuItem(n.ToString());
                item.Name = n.Id.ToString();
                item.Click += rimuoviNoleggioToolStripMenuItem_Click;
                rimuoviNoleggioToolStripMenuItem.DropDownItems.Add(item);
            }
        }
    }
}
