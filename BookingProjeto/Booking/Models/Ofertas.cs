using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Ofertas
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }


        public string HotelName { get; set; }
        public string RoomCategory { get; set; }

        public decimal Price { get; set; }
        //public decimal PriceBeforeDiscount { get; set; }
    }
}
