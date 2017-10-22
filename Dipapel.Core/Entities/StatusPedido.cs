using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.Entities
{
    [Table("tblstatus_pedido")]
    public class StatusPedido: Entity
    {
        public StatusPedido()
        {
            Pedidos = new List<Pedido>();
        }

        [Key]
        [Column("IDSTATUS_PEDIDO")]
        public int Id { get; set; }

        [Column("CODIGO", TypeName = "varchar")]
        [MaxLength(45)]
        [Index(IsUnique = true)]
        public string Codigo { get; set; }

        [Column("DESCRICAO", TypeName = "varchar")]
        [MaxLength(100)]
        public string Descricao { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; } 
    }
}
