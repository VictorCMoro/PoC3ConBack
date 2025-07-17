using PoC3ConDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConDomain.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<List<Cliente>> GetAllClientes();
        Task<Cliente?> GetClienteById(Guid id);
        Task<Cliente> CreateCliente(Cliente cliente);
        Task<Cliente?> UpdateCliente(Cliente cliente);
        Task<Cliente?> DeleteCliente(Guid id);
    }
}
