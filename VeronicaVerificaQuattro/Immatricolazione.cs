using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeronicaVerificaQuattro
{
    class Immatricolazione
    {
        private static int _matricola = 0;
        private CorsiLaurea _corsoLaurea; 

        public int Matricola { get; }
        public DateTime DataInizio { get;  }
        public bool FuoriCorso { get; }
        public int CFUAccumulati { get; }

        public Immatricolazione (DateTime dataInizio, CorsiLaurea corsolaurea, bool fuoriCorso, int cfuAccumulati)
        {
            _corsoLaurea = corsolaurea;
            Matricola = ++_matricola;
            DataInizio = dataInizio;
            FuoriCorso = fuoriCorso;
            CFUAccumulati = cfuAccumulati;
        }
        public string CorsoLaureaStudente
        {
            get
            {
                return $"il corso di laurea è: {_corsoLaurea}";
            }
        }

    }
}