using PoC3ConDomain.Abstractions;
using PoC3ConDomain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConDomain.Entities
{
    public class Cliente : Pessoa
    {
        public required string Cpf { get; set; }
        public DateOnly DataNascimento { get; set; }
        public ICollection<Pedido>? Pedidos { get; set; }

        public Cliente() { }
    }
}
