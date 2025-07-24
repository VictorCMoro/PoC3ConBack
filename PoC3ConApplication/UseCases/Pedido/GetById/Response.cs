using PoC3ConDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConApplication.UseCases.Pedido.GetById
{
    public sealed record Response(List<PoC3ConDomain.Entities.Pedido> ListaDePedidos);
}
