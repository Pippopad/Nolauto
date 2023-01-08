using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nolauto.DialogBox
{
    public partial class SelezionaVeicoloDialog : Form
    {
        public Veicolo VeicoloSelezionato { get; private set; }

        public SelezionaVeicoloDialog()
        {
            InitializeComponent();

            foreach (Veicolo v in GestoreVeicoli.GetAll())
            {
                lstVeicoli.Items.Add(v);
            }

            Button cancel = new Button();
            cancel.Click += (s, o) => this.DialogResult = DialogResult.Abort;
            this.CancelButton = cancel;
        }

        private void lstVeicoli_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstVeicoli.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                VeicoloSelezionato = lstVeicoli.SelectedItem as Veicolo;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void lstVeicoli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lstVeicoli.SelectedIndex != ListBox.NoMatches)
            {
                VeicoloSelezionato = lstVeicoli.SelectedItem as Veicolo;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
