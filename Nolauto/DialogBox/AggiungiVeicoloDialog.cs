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
                        break;
                    case TipoVeicolo.Furgone:
                        lblPostiCapacita.Text = "Capacità di carico:";
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
            GestoreVeicoli.AggiungiVeicolo(v);

            this.DialogResult = DialogResult.OK;
        }
    }
}
