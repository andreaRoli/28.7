using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    public enum Tipologia
    {
        singola,
        doppia
    }
    internal class Camera
    {
        public int Numero { get; set; }
        public string Descrizione { get; set; }
        public Tipologia Tipologia { get; set; }
    }
}
