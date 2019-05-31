using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class QuartosCheck
    {
        public QuartosCheck()
        {

        }

        public QuartosCheck(long idTipoQuarto, long idHotel, string tipoQuarto, int inventario)
        {
            IdTipoQuarto = idTipoQuarto;
            IdHotel = idHotel;
            TipoQuarto = tipoQuarto;
            Inventario = inventario;
        }

        public long IdTipoQuarto { get; set; }

        public long IdHotel { get; set; }
        
        public string TipoQuarto { get; set; }

        public int Inventario { get; set; }

    }
}
