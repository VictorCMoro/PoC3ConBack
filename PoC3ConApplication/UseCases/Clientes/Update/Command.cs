using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConApplication.UseCases.Clientes.Update
{
    public sealed record Command(PoC3ConDomain.Entities.Cliente Cliente) : IRequest<Response>;
}
