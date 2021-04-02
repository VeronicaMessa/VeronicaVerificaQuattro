using System;

namespace VeronicaVerificaQuattro
{
    class Program
    {
        static void Main(string[] args)
        {

            // creazione corsi
            Corsi analisi = new Corsi("analisi", 14);
            Corsi fisica1 = new Corsi("fisica1", 12);
            Corsi algebra = new Corsi("algebra", 10);
            Corsi filosofia = new Corsi("filosofia", 9);

            //creazione corsi di laurea
            CorsiLaurea ingegneria = new CorsiLaurea(NomeCorso.Ingegneria, DateTime.Today, algebra,380);
            CorsiLaurea informatica = new CorsiLaurea(NomeCorso.Informatica, DateTime.Today,analisi, 300);
            CorsiLaurea lettere = new CorsiLaurea(NomeCorso.Lettere, DateTime.Today, filosofia, 200);
            CorsiLaurea fisica = new CorsiLaurea(NomeCorso.Fisica, DateTime.Today,fisica1, 300);
            CorsiLaurea matematica = new CorsiLaurea(NomeCorso.Matematica, DateTime.Today,analisi, 380);

            // creazione immatricolazione 
            Immatricolazione imm1 = new Immatricolazione(DateTime.Today, ingegneria, true, 30);
            Immatricolazione imm2 = new Immatricolazione(DateTime.Today, matematica, false, 200);
            Immatricolazione imm3 = new Immatricolazione(DateTime.Today, fisica, true, 100);
            Immatricolazione imm4 = new Immatricolazione(DateTime.Today, lettere, false, 180);

            // creazione studenti 
            Studenti veronica = new Studenti("veronica", "messa", DateTime.Today, false, imm2);
            Studenti anna = new Studenti("anna", "pippo", DateTime.Today, false, imm1);
            Studenti miriam = new Studenti("miriam", "gino", DateTime.Today, false, imm3);
            Studenti giorgia = new Studenti("giorgia", "lino", DateTime.Today, false, imm4);

            // corso di laurea di ogni studente 
            
        }
    }
}
