using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class ViewModel

    {
        public ViewModel(List<QuartosDisp> quartos, List<EspecificacoesQuarto> esp)
        {
            Quartos = quartos;
            Esp = esp;

        }

        public List<EspecificacoesQuarto> Esp { get; private set; }
        public List<QuartosDisp> Quartos { get; private set; }
    }
}
