using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D2_Homework_Backend
{
    public class InformazioniPersonali
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public InformazioniPersonali() { }
        public InformazioniPersonali(string nome, string cognome, string telefono, string email)
        {
            Nome = nome;
            Cognome = cognome;
            Telefono = telefono;
            Email = email;
        }
    }
}
