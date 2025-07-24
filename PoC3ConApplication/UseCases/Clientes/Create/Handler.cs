using MediatR;
using PoC3ConDomain.Factories;
using PoC3ConDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConApplication.UseCases.Clientes.Create
{
    public class Handler(IClienteRepository clienteRepository) : IRequestHandler<Command, Response>
    {
        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            var dto = request.ClienteDto;

            var cliente = ClienteFactory.Criar(
                dto.Nome,
                dto.Email,
                dto.Telefone,
                dto.Cpf,
                dto.DataNascimento
            );
            

            var clienteCriado = await clienteRepository.CreateCliente(cliente);

            return new Response(clienteCriado);
        }
    }
}
