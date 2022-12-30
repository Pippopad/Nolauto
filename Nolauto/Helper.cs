using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nolauto
{
    public static class Helper
    {
        public static bool ControlloTarga(string targa)
        {
            Regex re = new Regex(@"^[a-zA-Z]{2}[\d]{3}[a-zA-Z]{2}$");
            return re.Matches(targa).Count != 0;
        }

        public static bool ControlloCodiceFiscale(string codiceFiscale)
        {
            Regex re = new Regex(@"^[a-zA-Z]{6}[\d]{2}[a-zA-Z]{1}[\d]{2}[a-zA-Z]{1}[\d]{3}[a-zA-Z]{1}$");
            return re.Matches(codiceFiscale).Count != 0;
        }

        public static bool ControlloStringa(string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

        public static void MsgErrore(string messaggio, string titolo)
        {
            MessageBox.Show(messaggio, titolo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
