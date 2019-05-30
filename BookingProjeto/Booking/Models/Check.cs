using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Check
    {
        public Check()
        {
        }

        public Check(int inv, long id, long idQuarto)
        {
            Inv = inv;
            Id = id;
            IdQuarto = idQuarto;
        }

        public long IdQuarto { get; set; }

        public int Inv { get; set; }

        public long Id { get; set; }
    }
}
