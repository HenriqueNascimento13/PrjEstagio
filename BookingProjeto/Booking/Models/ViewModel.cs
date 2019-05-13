using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class ViewModel

    {
        public ViewModel(List<Hoteis> hoteis, List<QuartosDisp> quartos)
        {
            Hoteis = hoteis;
            Quartos = quartos;

        }

        public List<Hoteis> Hoteis { get; private set; }
        public List<QuartosDisp> Quartos { get; private set; }
    }
}
