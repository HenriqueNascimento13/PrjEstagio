using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Booking
{
    public partial class Clientes
    {
        public Clientes(string nome, string sobrenome, string email, string telefone, string endereco, string codPostal, string localidade, string cc, string dataNasc)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Contacto = telefone;
            Morada = endereco;
            CodPostal = codPostal;
            Localidade = localidade;
            Cc = cc;
            DataNasc = dataNasc;
        }

        public Clientes()
        {
            Reservas = new HashSet<Reservas>();
        }

        public long Idcliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string Morada { get; set; }
        public string Localidade { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string CodPostal { get; set; }
        public string Cc { get; set; }
        public string DataNasc { get; set; }
        public string Imagem { get; set; }

        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}