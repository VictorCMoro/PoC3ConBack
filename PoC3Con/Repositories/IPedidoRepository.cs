using PoC3ConDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConDomain.Repositories
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        Task<List<Pedido>> GetPedidosById(Guid id);
        Task<Pedido> CreatePedido(Pedido pedido);
    }
}
