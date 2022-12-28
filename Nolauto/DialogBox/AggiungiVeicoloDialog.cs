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
    public partial class AggiungiVeicoloDialog : Form
    {
        private TipoVeicolo tipo;
        public TipoVeicolo Tipo
        {
            get => tipo;
            set
            {
                tipo = value;

                switch(tipo)
                {
                    case TipoVeicolo.Automobile:
                        lblPostiCapacita.Text = "Numero Posti:";
                        txtPostiCapacita.Minimum = 4;
                        txtPostiCapacita.Maximum = 7;
                        break;
                    case TipoVeicolo.Furgone:
                        lblPostiCapacita.Text = "Capacità di carico:";
                        txtPostiCapacita.Minimum = 300;
                        txtPostiCapacita.Maximum = 600;
                        break;
                }
            }
        }

        public AggiungiVeicoloDialog()
        {
            InitializeComponent();

            this.Tipo = TipoVeicolo.Automobile;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string targa = txtTarga.Text;
            string marca = txtMarca.Text;
            double tariffa = (double)txtTariffa.Value;
            double kilowatt = (double)txtKilowatt.Value;
            double postiCapacita = (double)txtPostiCapacita.Value;

            if (!Helper.ControlloTarga(targa))
            {
                Helper.MsgErrore("La targa non è valida!", this.Text);
                return;
            }

            if (!Helper.ControlloStringa(marca))
            {
                Helper.MsgErrore("Inserisci la marca!", this.Text);
                return;
            }

            Veicolo v = null;
            switch (this.Tipo)
            {
                case TipoVeicolo.Automobile:
                    v = new Automobile(targa, marca, tariffa, kilowatt, (int)postiCapacita);
                    break;
                case TipoVeicolo.Furgone:
                    v = new Furgone(targa, marca, tariffa, kilowatt, postiCapacita);
                    break;
            }

            if (!GestoreVeicoli.AggiungiVeicolo(v))
            {
                Helper.MsgErrore("Esiste già un veicolo con questa targa!", this.Text);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
