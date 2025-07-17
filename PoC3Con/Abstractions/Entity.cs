using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConDomain.Abstractions
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        public void SetId(Guid id) 
        {
            if(this.Id == Guid.Empty) 
                this.Id = id;
        }
    }
}
