using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConDomain.Abstractions
{
    public abstract class Pessoa : Entity
    {
        public required string Nome{ get; set; }
        public required string Email { get; set; }
        public string? Telefone { get; set; }
    }
}
