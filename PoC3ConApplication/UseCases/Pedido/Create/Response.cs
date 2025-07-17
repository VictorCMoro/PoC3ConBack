using PoC3ConDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConApplication.UseCases.Pedido.Create
{
    public sealed record Response(PoC3ConDomain.Entities.Pedido Pedido);
}
