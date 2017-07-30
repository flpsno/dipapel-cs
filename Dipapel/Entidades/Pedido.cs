using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Entidades
{
    enum StatusPedido
    {
        AGUARDANDO_PAGAMENTO,
        AGUARDANDO_COMPRADOR_ESCOLHER_FRETE,
        AGUARDANDO_FRETE,
        AGUARDANDO_CONFIRMACAO_PAGAMENTO,
        PAGO_ESPERANDO_VENDEDOR,
        PEDIDO_ENVIADO
    }

    class Pedido
    {     
        public string Codigo { get; set; }
        public string Comprador { get; set; }
        public StatusPedido Status { get; set; }
        public string DataPedido { get; set; }
        public byte TotalItens { get; set; }
        public double ValorTotal { get; set; }
        public string TipoFrete { get; set; }
        public double ValorFrete { get; set; }
    }
}
