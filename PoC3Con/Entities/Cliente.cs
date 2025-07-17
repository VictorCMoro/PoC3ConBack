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
        public DateTime DataNascimento { get; set; }
        public ICollection<Pedido>? Pedidos { get; set; }

        public Cliente(string nome, string email, string telefone, string cpf, DateTime dataNascimento)
        {
            if (!EmailValidator.EhValido(email))
                throw new ArgumentException("E-mail inválido");

            if (!string.IsNullOrWhiteSpace(telefone) && !TelefoneValidator.EhValido(telefone))
                throw new ArgumentException("Telefone inválido");

            if (!CpfValidator.EhValido(cpf))
                throw new ArgumentException("CPF inválido");

            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
            DataNascimento = dataNascimento.Date;
        }
        public Cliente() { }
    }
}
