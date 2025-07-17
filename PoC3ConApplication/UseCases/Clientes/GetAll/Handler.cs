using MediatR;
using PoC3ConDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConApplication.UseCases.Clientes.GetAll
{
    public class Handler(IClienteRepository clienteRepository) : IRequestHandler<Command, Response>
    {
        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            var listaDeCliente = await clienteRepository.GetAllClientes();

            return new Response(listaDeCliente);
        }
    }
}
