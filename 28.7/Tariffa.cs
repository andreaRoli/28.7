using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    public enum Tipologia2
    {
        singola,
        doppia
    }
    public enum Trattamento
    {
        prernottamentoPrimaColazione,
        pensioneCompleta,
        mezzaPensione
    }
    internal class Tariffa
    {
        public Tipologia Tipologia { get; set; }
        public Trattamento Trattamento { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
    }
}
