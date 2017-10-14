using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.Entities
{
    [Table("tblpedido")]
    public class Pedido: Entity
    {
        [Key]
        public int Codigo { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Comprador { get; set; }
        public string DataPedido { get; set; }
        public byte TotalItens { get; set; }
        public double ValorTotal { get; set; }
        public string TipoFrete { get; set; }
        public double ValorFrete { get; set; }
   //     public StatusPedido Status { get; set; }
    }
}
