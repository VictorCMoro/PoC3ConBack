using PoC3ConDomain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConDomain.Repositories
{
    public interface IRepository<T> where T : Entity;
}
