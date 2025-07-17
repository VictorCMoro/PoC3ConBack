using MediatR;
using PoC3ConDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConApplication.UseCases.Pedido.Create
{
    public class Handler(IPedidoRepository pedidoRepository, IClienteRepository clienteRepository) : IRequestHandler<Command, Response>
    {
        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            var cliente = await clienteRepository.GetClienteById(request.Pedido.ClienteId);

            if (cliente == null) 
            {
                return null;    
            }

            var pedido = await pedidoRepository.CreatePedido(request.Pedido);

            return new Response(pedido);
        }
    }
}
