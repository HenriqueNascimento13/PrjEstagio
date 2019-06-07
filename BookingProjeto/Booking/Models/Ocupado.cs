using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Ocupado
    {
        public Ocupado()
        {

        }
        public Ocupado(long idReserva, long idHotel, long idTipoQuarto, DateTime checkIn, DateTime checkOut)
        {
            Idreserva = idReserva;
            Idhotel = idHotel;
            IdtipoQuarto = idTipoQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public Ocupado(long idReserva, long idHotel, long idTipoQuarto, DateTime checkIn, DateTime checkOut, List<DateTime> datas)
        {
            Idreserva = idReserva;
            Idhotel = idHotel;
            IdtipoQuarto = idTipoQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Datas = datas;
        }

        public long Idreserva { get; set; }
        public long Idhotel { get; set; }
        public long IdtipoQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int QuantQuartos { get; set; }
        public List<DateTime> Datas { get; set; }
    }
}
