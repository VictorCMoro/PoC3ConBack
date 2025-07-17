using Microsoft.EntityFrameworkCore;
using PoC3ConDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConInfraestructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> context) : DbContext(context)
    {
        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Pedido> Pedidos { get; set; } = null!;
    }
}
