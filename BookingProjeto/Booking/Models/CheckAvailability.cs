using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class CheckAvailability
    {
        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public string TipoQuarto { get; set; }

        public int Inventario { get; set; }
    }
}
