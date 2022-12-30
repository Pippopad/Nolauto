using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Nolauto.DialogBox
{
    public partial class AggiungiNoleggioDialog : Form
    {
        private Cliente cliente;
        private Veicolo veicolo;

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

            Noleggio risultato = GestoreNoleggi.AggiungiNoleggio(dtpDataInizio.Value, (int)txtNumeroGiorni.Value, (double)txtCosto.Value, cliente, veicolo);
            if (risultato != null)
            {
                Helper.MsgErrore($"Impossibile noleggiare il veicolo per questa data perché è già stato prenotato! (ID: {risultato.Id})", this.Text);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnSelezionaVeicolo_Click(object sender, EventArgs e)
        {
            using (var svDialog = new SelezionaVeicoloDialog())
            {
                if (svDialog.ShowDialog() == DialogResult.OK)
                {
                    veicolo = svDialog.VeicoloSelezionato;
                    txtVeicolo.Text = svDialog.VeicoloSelezionato.Targa;

                    txtCosto.Value = (decimal)svDialog.VeicoloSelezionato.Tariffa * txtNumeroGiorni.Value;
                }
            }
        }

        private void btnSelezionaCliente_Click(object sender, EventArgs e)
        {
            using (var scDialog = new SelezionaClienteDialog())
            {
                if (scDialog.ShowDialog() == DialogResult.OK)
                {
                    cliente = scDialog.ClienteSelezionato;
                    txtCliente.Text = scDialog.ClienteSelezionato.CodiceFiscale;
                }
            }
        }

        private void txtNumeroGiorni_ValueChanged(object sender, EventArgs e)
        {
            if (veicolo != null)
                txtCosto.Value = (decimal)veicolo.Tariffa * txtNumeroGiorni.Value;
        }
    }
}
