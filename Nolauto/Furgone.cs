﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nolauto
{
    public class Furgone : Veicolo
    {
        public double CapacitaDiCarico { get; set; }

        public Furgone(string targa, string modello, double tariffa, double kilowatt, double capacitaDiCarico) : base(targa, modello, tariffa, kilowatt)
        {
            this.CapacitaDiCarico = capacitaDiCarico;
        }
    }
}
