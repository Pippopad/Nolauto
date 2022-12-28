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
    public partial class AggiungiNoleggioDialog : Form
    {
        public AggiungiNoleggioDialog()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            // Controllo input

            // Validazione data

            // Aggiunta noleggio

            this.DialogResult = DialogResult.OK;
        }

        private void btnSelezionaVeicolo_Click(object sender, EventArgs e)
        {
            using (var svDialog = new SelezionaVeicoloDialog())
            {
                if (svDialog.ShowDialog() == DialogResult.OK)
                {
                    txtVeicolo.Text = svDialog.VeicoloSelezionato.Targa;
                }
            }
        }
    }
}
