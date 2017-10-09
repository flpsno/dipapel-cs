using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.ConsoleTeste.Entities
{
    public class Pedido
    {
        public string Codigo { get; set; }
        public string Comprador { get; set; }
        public string DataPedido { get; set; }
        public byte TotalItens { get; set; }
        public double ValorTotal { get; set; }
        public string TipoFrete { get; set; }
        public double ValorFrete { get; set; }
        public StatusPedido Status { get; set; }
    }
}
