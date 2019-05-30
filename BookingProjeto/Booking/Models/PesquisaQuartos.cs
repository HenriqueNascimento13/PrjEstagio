using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class PesquisaQuartos
    {
        public long IdTipoQuarto { get; set; }

        public long IdHotel { get; set; }

        public string Descricao { get; set; }
    }
}
