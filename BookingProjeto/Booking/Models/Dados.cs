using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Dados
    {
        public Dados(string nome, string quarto, decimal preco, DateTime checkIn, DateTime checkOut, int capacidade, string morada, string localidade, string codPostal, string pais)
        {
            NomeHotel = nome;
            TipoQuarto = quarto;
            Preco = preco;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Capacidade = capacidade;
            Morada = morada;
            Localidade = localidade;
            CodPostal = codPostal;
            Pais = pais;
        }

        public string NomeHotel { get; set; }

        public string TipoQuarto { get; set; }

        public decimal Preco { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public int Capacidade { get; set; }

        public string Morada { get; set; }

        public string Localidade { get; set; }

        public string CodPostal { get; set; }

        public string Pais { get; set; }
    }
}
