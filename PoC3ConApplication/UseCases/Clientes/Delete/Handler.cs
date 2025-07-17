using MediatR;
using PoC3ConDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConApplication.UseCases.Clientes.Delete
{
    public class Handler(IClienteRepository clienteRepository) : IRequestHandler<Command, Response>
    {
        public async Task<Response?> Handle(Command request, CancellationToken cancellationToken)
        {
            var cliente = await clienteRepository.DeleteCliente(request.Id);

            if(cliente == null)
            {
                return null;
            }
            
            return new Response(cliente);
        }
    }
}
