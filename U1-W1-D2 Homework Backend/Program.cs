using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D2_Homework_Backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CV IronMan = new CV();
            IronMan.InformazioniPersonali = new InformazioniPersonali("Tony", "Stark", "+3912345678", "tonymilardiario@riccone.com");
            IronMan.Studi = new Studi("Ingegneria Fisica", "MIT", "Laurea", "01/09/80", "01/07/1983");
            Esperienza esperienzaTony1 = new Esperienza("Stark Industries", "Inventore", "1/01/1989", "Data Corrente", "Fabbricazione Armi", "Design di Armi");
            Esperienza esperienzaTony2 = new Esperienza("Shield", "Avengers", "1/01/2013", "Data Corrente", "Respingere Minacce a livello Mondiale", "Combattente sfruttando i Poteri della propria Armatura");
            IronMan.Impiego = new Impiego();
            IronMan.Impiego.ListaEsperienza.Add(esperienzaTony1);
            IronMan.Impiego.ListaEsperienza.Add(esperienzaTony2);

            IronMan.StampaDettagliCVSuSchermo(IronMan);



        }
    }
}
