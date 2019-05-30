using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class CheckAvailability
    {
        public CheckAvailability()
        {
        }

        public CheckAvailability(int inv, long id, long idQuarto)
        {
            Inv = inv;
            Id = id;
            IdQuarto = idQuarto;
        }

        public long IdQuarto { get; set; }

        public int Inv { get; set; }

        public long Id { get; set; }

        //public DateTime CheckIn { get; set; }

        //public DateTime CheckOut { get; set; }

        //public string TipoQuarto { get; set; }

        //public int Inventario { get; set; }
    }
}
