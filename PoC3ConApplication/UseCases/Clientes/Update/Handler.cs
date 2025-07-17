using MediatR;
using PoC3ConDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConApplication.UseCases.Clientes.Update
{
    public class Handler(IClienteRepository clienteRepository) : IRequestHandler<Command, Response>
    {
        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            var cliente = await clienteRepository.UpdateCliente(request.Cliente);

            return new Response(cliente);
        }
    }
}
