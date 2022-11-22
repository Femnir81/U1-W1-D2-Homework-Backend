using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D2_Homework_Backend
{
    internal class CV
    {
        public InformazioniPersonali InformazioniPersonali { get; set; }
        public Studi Studi { get; set; }
        public Impiego Impiego { get; set; }

        public void StampaDettagliCVSuSchermo(CV cv)
        {
            Console.WriteLine($"CV di {cv.InformazioniPersonali.Cognome} {cv.InformazioniPersonali.Nome}");
            Console.WriteLine("");
            Console.WriteLine("++++ INIZIO Informazioni Personali: ++++");
            Console.WriteLine($"Nome: {cv.InformazioniPersonali.Nome}");
            Console.WriteLine($"Cognome: {cv.InformazioniPersonali.Cognome}");
            Console.WriteLine($"Email: {cv.InformazioniPersonali.Email}");
            Console.WriteLine($"Telefono: {cv.InformazioniPersonali.Telefono}");
            Console.WriteLine("++++ FINE Informazioni Personali ++++");
            Console.WriteLine("");
            Console.WriteLine("++++ INIZIO Studi e Formazione: ++++");
            Console.WriteLine($"Istituto: {cv.Studi.Istituto}");
            Console.WriteLine($"Qualifica: {cv.Studi.Qualifica}");
            Console.WriteLine($"Tipo: {cv.Studi.Tipo}");
            Console.WriteLine($"Dal {cv.Studi.Dal} al {cv.Studi.Al}");
            Console.WriteLine("");
            Console.WriteLine("++++ Fine Studi e Formazione ++++");
            Console.WriteLine("");
            Console.WriteLine("++++ INIZIO Esperienze professionali: ++++");
            foreach (Esperienza item in cv.Impiego.ListaEsperienza)
            {
                Console.WriteLine($"Presso: {item.Azienda}");
                Console.WriteLine($"Titolo: {item.JobTitle}");
                Console.WriteLine($"Descrizione: {item.Descrizione}");
                Console.WriteLine($"Compiti: {item.Compiti}");
                Console.WriteLine($"Dal {item.Dal} al {item.Al}");
                Console.WriteLine("");
            }
            Console.WriteLine("++++ FINE Esperienze professionali: ++++");
        }
    }

}
