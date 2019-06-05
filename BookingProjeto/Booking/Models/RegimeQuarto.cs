using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class RegimeQuarto
    {
        public RegimeQuarto()
        {
        }

        public byte Idregime { get; set; }
        public long Idhotel { get; set; }
        public string Regime { get; set; }
        public decimal Preco { get; set; }
    }
}
