using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Albergo
    {
        public List<Prenotazione> Prenotazioni { get; set; }
        public void StampaPrenotazioni()
        {
            foreach(Prenotazione pre in Prenotazioni)
            {
                Console.WriteLine(
                pre.NumeroProgressivo.ToString(),
                pre.Anno,
                pre.DataPrenotazione,
                pre.Cliente.Nome,
                pre.Cliente.Cognome,
                pre.Cliente.CodiceFiscale,
                pre.Cliente.Città,
                pre.Cliente.Provincia,
                pre.Cliente.Email,
                pre.Cliente.Cellulare,
                pre.Cliente.Telefono,
                pre.Dal,
                pre.Al,
                pre.Caparra,
                pre.TariffaApplicata.Tipologia,
                pre.TariffaApplicata.Trattamento
                );
                
            
            }
        }
    }
}
