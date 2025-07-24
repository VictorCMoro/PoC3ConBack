using MediatR;
using PoC3ConDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConApplication.UseCases.Pedido.GetById
{
    public class Handler(IPedidoRepository pedidoRepository) : IRequestHandler<Command, Response>
    {
        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            var listaDePedidos = await pedidoRepository.GetPedidosById(request.id);

            return new Response(listaDePedidos);
        }
    }
}
