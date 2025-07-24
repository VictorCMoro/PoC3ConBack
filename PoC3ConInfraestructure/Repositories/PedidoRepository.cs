using Microsoft.EntityFrameworkCore;
using PoC3ConDomain.Entities;
using PoC3ConDomain.Repositories;
using PoC3ConInfraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConInfraestructure.Repositories
{
    public class PedidoRepository(AppDbContext appDbContext) : IPedidoRepository
    {
        public async Task<Pedido> CreatePedido(Pedido pedido)
        {
            var newPedido = await appDbContext.Pedidos.AddAsync(pedido);
            await appDbContext.SaveChangesAsync();
            return newPedido.Entity;
        }
        public async Task<List<Pedido>> GetPedidosById(Guid id)
        {
            return await appDbContext.Pedidos
                .Where(p => p.ClienteId == id)
                .ToListAsync();
        }
    }
}
