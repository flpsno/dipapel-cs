using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Entidades
{
    class PedidoDAO
    {
        private List<Pedido> _listaPedidos;

        public PedidoDAO()
        {
            _listaPedidos = new List<Pedido>();
        }

        public void Adicionar(Pedido pedido)
        {
            _listaPedidos.Add(pedido);
        }

        public int TotalPedidos()
        {
            return _listaPedidos.Count();
        }

        public List<Pedido> ObterTodos()
        {
            return _listaPedidos;
        }
    }
}
