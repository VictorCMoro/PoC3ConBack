using PoC3ConDomain.Entities;
using PoC3ConDomain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConDomain.Factories
{
    public static class ClienteFactory
    {
        public static Cliente Criar(string nome, string email, string telefone, string cpf, DateOnly dataNascimento)
        {
            if (!EmailValidator.EhValido(email))
                throw new ArgumentException("E-mail inválido");

            if (!string.IsNullOrWhiteSpace(telefone) && !TelefoneValidator.EhValido(telefone))
                throw new ArgumentException("Telefone inválido");

            if (!CpfValidator.EhValido(cpf))
                throw new ArgumentException("CPF inválido");

            if (!DataNascimentoValidator.EhValido(dataNascimento))
                throw new ArgumentException("Cliente deve ter mais ou 18 anos");

            return new Cliente
            {
                Nome = nome,
                Email = email,
                Telefone = telefone,
                Cpf = cpf,
                DataNascimento = dataNascimento
            };
        }
    }
}
