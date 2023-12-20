using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Program
    {
       
       
        static void Main(string[] args)
        {
            Prenotazione pre = new Prenotazione();
            pre.NumeroProgressivo = 29;
            pre.Anno = 2023;
            pre.DataPrenotazione = new DateTime(2023, 11, 2);
            pre.Cliente.Nome = "Andrea";
            pre.Cliente.Cognome = "Roli";
            pre.Cliente.CodiceFiscale = "RlO06";
            pre.Cliente.Città = "Castelvetro";
            pre.Cliente.Provincia = "Modena";
            pre.Cliente.Email = "Ciao09@gmail.com";
            pre.Cliente.Cellulare = "3398899324";
            pre.Cliente.Telefono = "0593827383";
            pre.Dal = new DateTime(2023, 12, 25);
            pre.Al = new DateTime(2023, 12, 30);
            pre.Caparra = 209;
            pre.TariffaApplicata.Tipologia = Tipologia.singola;
            pre.TariffaApplicata.Trattamento = Trattamento.pensioneCompleta;
           Servizio servizio = new Servizio();
            servizio.Descrizione = "Internet";
            servizio.Quantità = 1;
            servizio.Data = new DateTime(2023, 12, 27);
            servizio.Prezzo = 60;

            




        }

}
}
