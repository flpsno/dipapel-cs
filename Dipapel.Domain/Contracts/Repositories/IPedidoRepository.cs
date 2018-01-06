using Dipapel.Domain.Models;
using System;
using System.Collections.Generic;

namespace Dipapel.Domain.Contracts.Repositories
{
    public interface IPedidoRepository : IDisposable
    {
        IEnumerable<Pedido> GetAll();
        Pedido GetByID(int id);
        Pedido Insert(Pedido pedido);
        Pedido Edit(Pedido pedido);
        void Delete(Pedido pedido);
    }
}
