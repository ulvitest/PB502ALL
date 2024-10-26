using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtensionsStructEnumCasting.Casting.Models
{
    internal class Dollar
    {
        public Dollar(double usd)
        {
            Usd = usd;
        }

        public double Usd { get; set; }
    }
    internal class Manat
    {
        public Manat(double azn)
        {
            Azn = azn;
        }

        public double Azn { get; set; }

        public static implicit operator Dollar(Manat m)
        {
            return new Dollar(m.Azn / 1.7);
        }
    }
}
