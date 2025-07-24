using PoC3ConDomain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConDomain.Entities
{
    public class Pedido : Entity
    {
        public required Guid ClienteId { get; set; }
        public required DateOnly DataPedido { get; set; }
        public required string Descricao { get; set; }
        public required decimal Valor { get; set; }

        public Pedido(Guid clienteId, DateOnly dataPedido, string descricao, decimal valor)
        {
            ClienteId = clienteId;
            DataPedido = dataPedido;
            Descricao = descricao;
            Valor = valor;
        }

        public Pedido() { }
    }
}
