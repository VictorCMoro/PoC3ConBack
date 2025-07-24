using MediatR;
using PoC3ConDomain.Entities;
using PoC3ConDomain.Repositories;

namespace PoC3ConAPI.Routes
{
    public static class PedidoRoutes
    {
        public static IEndpointRouteBuilder MapPedidoRoutes(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/Pedidos").WithTags("Pedidos");

            group.MapGet("/{id}", async (ISender sender, Guid id) =>
            {
                var command = new PoC3ConApplication.UseCases.Pedido.GetById.Command(id);
                var result = await sender.Send(command);

                return Results.Ok(result);
            });

            group.MapPost("/", async (ISender sender, Pedido pedido) =>
            {
                if(pedido.Valor <= 0)
                {
                    return Results.BadRequest("O valor do pedido tem que ser maior que 0");
                }
                var command = new PoC3ConApplication.UseCases.Pedido.Create.Command(pedido);
                var result = await sender.Send(command);

                return Results.Ok(result);
            });

            return app;
        }
    }
}
