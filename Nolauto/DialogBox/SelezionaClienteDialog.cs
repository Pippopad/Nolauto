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
    public partial class SelezionaClienteDialog : Form
    {
        public Cliente ClienteSelezionato { get; private set; }

        public SelezionaClienteDialog()
        {
            InitializeComponent();

            foreach (Cliente v in GestoreClienti.GetAll())
            {
                lstClienti.Items.Add(v);
            }
        }

        private void lstClienti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstClienti.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                ClienteSelezionato = lstClienti.SelectedItem as Cliente;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void lstClienti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lstClienti.SelectedIndex != ListBox.NoMatches)
            {
                ClienteSelezionato = lstClienti.SelectedItem as Cliente;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
