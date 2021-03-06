﻿using System;
using System.Collections.Generic;

namespace Booking
{
    public partial class Pagamento
    {
        public Pagamento()
        {
            Reservas = new HashSet<Reservas>();
        }

        public long CodPagamento { get; set; }
        public short IdtipoPagamento { get; set; }
        public string NomeTitular { get; set; }
        public string NumCartao { get; set; }
        public string DataValidadeCartao { get; set; }
        public string Cvv { get; set; }

        public virtual TipoPagamento IdtipoPagamentoNavigation { get; set; }
        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}