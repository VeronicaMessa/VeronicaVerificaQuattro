using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeronicaVerificaQuattro
{
    class Esami
    {
        public bool Conseguito { get; }
        private Corsi _corso;

        public Esami (Corsi corso, bool conseguito)
        {
            _corso = corso;
            Conseguito = conseguito;
        }
        public string EsamiPerCorsi
        {
            get
            {
                return$"{_corso}";
            }
        }
    }
}