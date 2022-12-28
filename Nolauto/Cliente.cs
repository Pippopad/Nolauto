using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nolauto
{
    public class Cliente
    {
        public string CodiceFiscale { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Cliente(string codiceFiscale, string nome, string cognome)
        {
            this.CodiceFiscale = codiceFiscale.ToUpper();
            this.Nome = nome;
            this.Cognome = cognome;
        }

        public override string ToString()
        {
            return $"{this.Nome} {this.Cognome} ({this.CodiceFiscale})";
        }
    }
}
