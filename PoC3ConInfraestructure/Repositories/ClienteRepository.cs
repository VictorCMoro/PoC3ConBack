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
    public class ClienteRepository(AppDbContext appDbContext) : IClienteRepository
    {
        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            var newCliente = await appDbContext.Clientes.AddAsync(cliente);
            await appDbContext.SaveChangesAsync();
            return newCliente.Entity;
        }

        public async Task<Cliente?> DeleteCliente(Guid id)
        {
            var cliente = await appDbContext.Clientes.FirstOrDefaultAsync(c => c.Id == id);
            if (cliente != null) {
                appDbContext.Clientes.Remove(cliente);
                appDbContext.SaveChanges();
                return cliente;
            }

            return null;
        }

        public async Task<List<Cliente>> GetAllClientes()
        {
            return await appDbContext.Clientes
                .Include(c => c.Pedidos)
                .ToListAsync();
        }

        public async Task<Cliente?> GetClienteById(Guid id)
        {
            var cliente = await appDbContext.Clientes
                .Include(c => c.Pedidos)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (cliente == null) 
            {
                return null;
            }

            return cliente;
        }

        public async Task<Cliente?> UpdateCliente(Cliente clienteAtualizado)
        {
            var cliente = await appDbContext.Clientes.FirstOrDefaultAsync(c => c.Id == clienteAtualizado.Id);
            if(cliente != null)
            {
                cliente.Nome = clienteAtualizado.Nome;
                cliente.Telefone = clienteAtualizado.Telefone;
                cliente.Cpf = clienteAtualizado.Cpf;
                cliente.DataNascimento = clienteAtualizado.DataNascimento;
                cliente.Pedidos = clienteAtualizado.Pedidos;

                appDbContext.Clientes.Update(cliente);
                await appDbContext.SaveChangesAsync();

                return cliente;
            }
            return null;
        }
    }
}
