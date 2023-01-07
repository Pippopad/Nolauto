using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nolauto.DialogBox
{
    public partial class AggiungiClienteDialog : Form
    {
        public AggiungiClienteDialog()
        {
            InitializeComponent();

            Button cancel = new Button();
            cancel.Click += (s, o) => this.DialogResult = DialogResult.Abort;
            this.CancelButton = cancel;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string codiceFiscale = txtCodiceFiscale.Text;
            string nome = txtNome.Text;
            string cognome = txtCognome.Text;

            if (!Helper.ControlloCodiceFiscale(codiceFiscale))
            {
                Helper.MsgErrore("Il codice fiscale non è valido!", this.Text);
                return;
            }

            if (!Helper.ControlloStringa(nome))
            {
                Helper.MsgErrore("Inserisci il nome!", this.Text);
                return;
            }

            if (!Helper.ControlloStringa(cognome))
            {
                Helper.MsgErrore("Inserisci il cognome!", this.Text);
                return;
            }

            Cliente c = new Cliente(codiceFiscale, nome, cognome);
            if (!GestoreClienti.AggiungiCliente(c))
            {
                Helper.MsgErrore("Esiste già un cliente con questo codice fiscale!", this.Text);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
