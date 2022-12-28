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
            if (!Helper.ControlloStringa(txtVeicolo.Text))
            {
                Helper.MsgErrore("Selezionare un veicolo!", this.Text);
                return;
            }

            if (!Helper.ControlloStringa(txtCliente.Text))
            {
                Helper.MsgErrore("Selezionare un cliente!", this.Text);
                return;
            }

            // TODO: Validazione data

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

        private void btnSelezionaCliente_Click(object sender, EventArgs e)
        {
            using (var scDialog = new SelezionaClienteDialog())
            {
                if (scDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCliente.Text = scDialog.ClienteSelezionato.CodiceFiscale;
                }
            }
        }
    }
}
