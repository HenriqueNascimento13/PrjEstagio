using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Inventario
    {
        public Inventario()
        {
        }

        public Inventario(int inv, long id, long idQuarto, string tipoQuarto)
        {
            Inv = inv;
            Id = id;
            IdQuarto = idQuarto;
            TipoQuarto = tipoQuarto;
        }

        public long IdQuarto { get; set; }

        public int Inv { get; set; }

        public long Id { get; set; }

        public string TipoQuarto { get; set; }
    }
}
