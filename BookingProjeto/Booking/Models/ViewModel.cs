using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class ViewModel

    {
        public ViewModel(List<QuartosDisp> quartos, List<TipoQuarto> tipo)
        {
            Quartos = quartos;
            Tipo = tipo;

        }

        public List<TipoQuarto> Tipo { get; private set; }
        public List<QuartosDisp> Quartos { get; private set; }
    }
}
