using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Oferta
    {
        public string hotelName { get; set; }
        public string roomCategory { get; set; }

        public decimal price { get; set; }
    }
}
