using MediatR;
using PoC3ConApplication.UseCases.Clientes.Create;
using PoC3ConDomain.Entities;
using PoC3ConDomain.Repositories;

namespace PoC3ConAPI.Routes
{
    public static class ClienteRoutes
    {
        public static IEndpointRouteBuilder MapClienteRoutes(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/Clientes").WithTags("Clientes");

            group.MapGet("", async (ISender sender) =>
            {
                var command = new PoC3ConApplication.UseCases.Clientes.GetAll.Command();
                var result = await sender.Send(command);

                return Results.Ok(result);
            });

            group.MapGet("{id}", async (ISender sender, Guid id) =>
            {
                var command = new PoC3ConApplication.UseCases.Clientes.GetById.Command(id);
                var result = await sender.Send(command);

                return result is not null
                    ? Results.Ok(result)
                    : Results.NotFound("Nenhum cliente encontrado");
            });

            group.MapDelete("{id}", async (ISender sender, Guid id) =>
            {
                var command = new PoC3ConApplication.UseCases.Clientes.Delete.Command(id);
                var result = await sender.Send(command);

                return result is not null
                    ? Results.Ok(result)
                    : Results.NotFound("Nenhum cliente encontrado");
            });

            group.MapPost("", async (ISender sender, ClienteDto clienteDto) =>
            {
                var command = new PoC3ConApplication.UseCases.Clientes.Create.Command(clienteDto);
                var result = await sender.Send(command);

                return result is not null
                    ? Results.Ok(result)
                    : Results.BadRequest("Erro ao executar cliente post");
            });

            group.MapPut("{id}", async (Guid id, ISender sender, Cliente cliente) =>
            {

                cliente.SetId(id);

                var command = new PoC3ConApplication.UseCases.Clientes.Update.Command(cliente);
                var result = await sender.Send(command);

                return result is not null
                    ? Results.Ok(result)
                    : Results.BadRequest("Erro ao executar cliente put");
            });

            return app;
        }
    }
}
