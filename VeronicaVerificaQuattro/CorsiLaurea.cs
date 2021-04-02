using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeronicaVerificaQuattro
{
    enum NomeCorso
    {
        Matematica,
        Fisica,
        Informatica,
        Ingegneria,
        Lettere
    }
    class CorsiLaurea
    {
        private List<Corsi> _corsi = new List<Corsi>();
        public DateTime AnnoDiCorso { get; }
        public int CFULaurea { get; }
        public NomeCorso NomeCorso { get; }


        public CorsiLaurea(NomeCorso nome,DateTime annoDiCorso,Corsi corsi, int cfuLaurea)
            {
      
                NomeCorso = nome;
                AnnoDiCorso = annoDiCorso;
                CFULaurea = cfuLaurea;

            }
    }     
}







    


