using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class ViewModel : PageModel
    {

        //public ViewModel(List<string> tipo) { 
        //    Tipo = tipo;
        //}

        public ViewModel(List<QuartosDisp> quartos)
        {
            Quartos = quartos;
        }

        public ViewModel(List<string> regimes, List<string> tipoPagamento, Dados dados)
        {
            Regimes = regimes;
            TipoPagamento = tipoPagamento;
            Dados = dados;
        }

        public List<string> TipoPagamento { get; private set; }
        public List<string> Regimes { get; private set; }


        public Dados Dados { get; private set; }
        public List<string> Tipo { get; private set; }
        public List<QuartosDisp> Quartos { get; private set; }
    }
}
