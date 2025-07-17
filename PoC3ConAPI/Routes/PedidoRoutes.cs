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

            group.MapGet("/", async (IPedidoRepository repository, ISender sender) =>
            {
                var command = new PoC3ConApplication.UseCases.Pedido.GetAll.Command();
                var result = await sender.Send(command);

                return Results.Ok(result);
            });

            group.MapPost("/", async (IPedidoRepository repository, ISender sender, Pedido pedido) =>
            {
                var command = new PoC3ConApplication.UseCases.Pedido.Create.Command(pedido);
                var result = await sender.Send(command);

                return Results.Ok(result);
            });

            return app;
        }
    }
}
