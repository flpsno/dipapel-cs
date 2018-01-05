using Dipapel.Domain.Models;
using System.Collections.Generic;

namespace Dipapel.Domain.Contracts.Repositories
{
    public interface IPedidoRepository
    {
        IEnumerable<Pedido> GetAll();
        Pedido GetByID(int id);
        Pedido Insert(Pedido pedido);
        Pedido Edit(Pedido pedido);
        void Delete(Pedido pedido);
    }
}
