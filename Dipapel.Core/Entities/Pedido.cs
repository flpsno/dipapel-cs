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
        [Column("IDPEDIDO")]
        public int Id { get; set; }

        [Column("CODIGO", TypeName ="varchar")]
        [MaxLength(15)]
        [Index(IsUnique = true)]
        public string Codigo { get; set; }

        [Column("COMPRADOR", TypeName = "varchar")]
        [MaxLength(100)]
        public string Comprador { get; set; }

        [Column("DATA_PEDIDO", TypeName = "date")]       
        public DateTime DataPedido { get; set; }

        [Column("TOTAL_ITENS")]
        public int TotalItens { get; set; }

        [Column("VALOR_TOTAL", TypeName = "float")]        
        public double ValorTotal { get; set; }

        [Column("TIPO_FRETE", TypeName = "varchar")]
        [MaxLength(50)]
        public string TipoFrete { get; set; }

        [Column("VALOR_FRETE", TypeName = "float")]
        public double ValorFrete { get; set; }

        [Column("IDSTATUS_PEDIDO")]
        public int IdStatusPedido { get; set; }

        [ForeignKey("IdStatusPedido")]
        public virtual StatusPedido StatusPedido { get; set; }
    }
}
