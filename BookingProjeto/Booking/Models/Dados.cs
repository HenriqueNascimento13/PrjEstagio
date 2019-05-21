using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Dados
    {
        public Dados(string nome, string quarto, decimal preco, DateTime checkIn, DateTime checkOut)
        {
            NomeHotel = nome;
            TipoQuarto = quarto;
            Preco = preco;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public string NomeHotel { get; set; }

        public string TipoQuarto { get; set; }

        public decimal Preco { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }
    }
}
