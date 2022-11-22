using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D2_Homework_Backend
{
    internal class Esperienza
    {
        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }
        public Esperienza () { }
        public Esperienza(string azienda, string jobTitle, string dal, string al, string descrizione, string compiti)
        {
            Azienda = azienda;
            JobTitle = jobTitle;
            Dal = dal;
            Al= al;
            Descrizione = descrizione;
            Compiti = compiti;
        }

    }
}
