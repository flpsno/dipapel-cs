using Dipapel.Core.Entities;
using Dipapel.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.EF.Repositories
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public Pedido ObterByCodigo(string codigo)
        {
            var pedido = _ctx.Pedidos.Where(p => p.Codigo.Contains(codigo));
            return pedido.FirstOrDefault<Pedido>();
        }
    }
}
