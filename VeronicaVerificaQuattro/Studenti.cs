using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeronicaVerificaQuattro
{
    class Studenti
    {

        private List<Esami> _esami = new List<Esami>();
        private Immatricolazione _immatricolazione; 
        public string Nome { get; }
        public string Cognome { get;  }
        public DateTime AnnoNascita { get; }
        public bool RichiestaLaurea { get;  }


        public Studenti (string nome, string cognome, DateTime annoNascita, bool richiestaLaurea, Immatricolazione immatricolazione)
        {
           _immatricolazione = immatricolazione;
            Nome = nome;
            Cognome = cognome;
            AnnoNascita = annoNascita;
            RichiestaLaurea = richiestaLaurea; 

        }
        public string ImmatricolazioneStudente
        {
            get
            {
                return $"{_immatricolazione}";
            }
        }

       


        
    }
}