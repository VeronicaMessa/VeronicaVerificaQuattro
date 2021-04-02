using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeronicaVerificaQuattro
{
    class Corsi
    {
        public string Nome { get; }
        public int CFU { get; }

        public Corsi (string nome, int cfu)
        {
            Nome = nome;
            CFU = cfu; 
        }
    }
}