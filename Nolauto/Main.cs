using Nolauto.DialogBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

            // Se il programma viene aperto trascinando un progetto
            // su di esso allora viene caricato il progetto.
            // Altrimenti vengono inizializzate le liste.
            if (Helper.Argomenti.Length != 0)
            {
                GestoreSalvataggi.PercorsoFile = Helper.Argomenti[0];
                if (!GestoreSalvataggi.Apri())
                {
                    Helper.MsgErrore("Impossibile aprire il progetto!", this.Text);
                    GestoreSalvataggi.PercorsoFile = "";
                    GestoreSalvataggi.Inizializza();
                }
                UpdateView();
            }
            else
            {
                // Inizializza la lista dei veicoli, dei clienti e quella dei noleggi
                GestoreSalvataggi.Inizializza();
            }
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Per creare un nuovo progetto (resettare il programma),
            // vengono reinizializzate le liste e viene aggiornata
            // anche la visuale.
            GestoreSalvataggi.Inizializza();
            UpdateView();
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Apre il menù di selezione del progetto e prova ad aprirlo
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleziona il progetto da aprire...";
                ofd.Multiselect = false;
                ofd.InitialDirectory = GestoreSalvataggi.ProjectsDir;
                ofd.CheckFileExists = true;
                ofd.Filter = "File JSON (*.json)|*.json";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    GestoreSalvataggi.PercorsoFile = ofd.FileName;

                    if (!GestoreSalvataggi.Apri())
                    {
                        Helper.MsgErrore("Impossibile aprire il progetto!", this.Text);
                        GestoreSalvataggi.PercorsoFile = "";
                        return;
                    }

                    UpdateView();
                }
            }
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se si sta modificando un progetto allora
            // la funzione salva aggiornerà il file,
            // altrimenti viene mostra la finestra per
            // selezionare la destinazione del progetto
            // da salvare.
            if (!Helper.ControlloStringa(GestoreSalvataggi.PercorsoFile)) SaveDialog();
            else GestoreSalvataggi.Salva();
        }

        private void salvaComeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Simile al "Salva" ma mostra direttamente la finestra per
            // selezionare la destinazione del progetto da salvare.
            SaveDialog();
        }

        private void SaveDialog()
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Salva progetto come...";
                sfd.FileName = Helper.ControlloStringa(GestoreSalvataggi.PercorsoFile) ? GestoreSalvataggi.PercorsoFile : "ProgettoSenzaNome.json";
                sfd.InitialDirectory = GestoreSalvataggi.ProjectsDir;
                sfd.CheckPathExists = true;
                sfd.Filter = "File JSON (*.json)|*.json";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    GestoreSalvataggi.PercorsoFile = sfd.FileName;
                    GestoreSalvataggi.Salva();
                }
            }
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
            // Aggiorna la ListView dei noleggi quando
            // viene selezionato un'altro veicolo.
            UpdateNoleggiListView();
        }

        private void UpdateView()
        {
            // Aggiorna tutti gli elementi della visuale dinamici.
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
