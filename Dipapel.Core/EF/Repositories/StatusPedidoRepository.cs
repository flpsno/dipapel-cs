using Dipapel.Core.Contracts;
using Dipapel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.EF.Repositories
{
    public class StatusPedidoRepository : Repository<StatusPedido>, IStatusPedidoRepository
    {
        public StatusPedido ObterByCodigo(string codigo)
        {
            var statusPedido = _ctx.StatusPedidos.Where(sp => sp.Codigo.Contains(codigo));
            return statusPedido.FirstOrDefault<StatusPedido>();
        }
    }
}
