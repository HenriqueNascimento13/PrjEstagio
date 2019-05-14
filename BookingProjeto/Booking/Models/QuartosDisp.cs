using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class QuartosDisp
    {
        public string Imagem { get; set; }

        public string TipoQuarto { get; set; }

        public int Capacidade { get; set; }

        public string NomeHotel { get; set; }

        public string NumEstrelas { get; set; }

        public string Morada { get; set; }

        public string Localidade { get; set; }

        public string CodPostal { get; set; }

        public string Pais { get; set; }

        public decimal Preco { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

    }
}
