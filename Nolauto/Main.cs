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

            GestoreVeicoli.RimuoviVeicolo(targa);
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

            GestoreClienti.RimuoviCliente(codiceFiscale);
            UpdateMenu();
        }

        private void UpdateView()
        {
            UpdateListView();
            UpdateMenu();
        }

        private void UpdateListView()
        {
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
        }
    }
}
