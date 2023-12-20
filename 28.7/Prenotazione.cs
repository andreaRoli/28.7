using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    
    internal class Prenotazione
    {
        public Cliente Cliente { get; set; }
        public DateTime DataPrenotazione { get; set; }
        public float NumeroProgressivo { get; set; }

        public int Anno { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
        public float Caparra { get; set; }
        public Tariffa TariffaApplicata { get; set; }

        public List <Servizio> Servizi { get; set; }

       
    }
}
