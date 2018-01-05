using System;

namespace Dipapel.Domain.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Comprador { get; set; }
        public DateTime DataPedido { get; set; }
        public int TotalItens { get; set; }
        public float ValorTotal { get; set; }
        public string TipoFrete { get; set; }
        public float ValorFrete { get; set; }
        public int IdStatusPedido { get; set; }
    }
}
