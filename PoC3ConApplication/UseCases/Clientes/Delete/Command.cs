using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConApplication.UseCases.Clientes.Delete
{
    public sealed record Command(Guid Id) : IRequest<Response>;
}
