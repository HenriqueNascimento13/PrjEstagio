using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class ViewModel : PageModel
    {
        public ViewModel()
        {

        }

        public ViewModel(List<QuartosDisp> quartos)
        {
            Quartos = quartos;
        }

        public ViewModel(List<RegimeQuarto> regimes, List<string> tipoPagamento, Dados dados, List<int> quantQuartos)
        {
            Regimes = regimes;
            TipoPagamento = tipoPagamento;
            Dados = dados;
            QuantQuartos = quantQuartos;
        }

        public List<string> TipoPagamento { get; private set; }
        public List<RegimeQuarto> Regimes { get; private set; }

        public List<int> QuantQuartos { get; set; }
        public Dados Dados { get; private set; }
        public List<string> Tipo { get; private set; }
        public List<QuartosDisp> Quartos { get; private set; }
        public List<QuartosCheck> QuartosCheck { get; private set; }
    }
}
