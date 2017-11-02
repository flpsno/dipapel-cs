using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.Entities
{
    [Table("tblusuario")]
    public class Usuario: Entity
    {
        [Key]
        [Column("IDUSUARIO")]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Column("NOME", TypeName = "varchar")]
        public string NOME { get; set; }

        [Required]
        [MaxLength(150)]
        [Column("EMAIL", TypeName = "varchar")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)")]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 6)]
        [Column("SENHA", TypeName = "varchar")]
        public string Senha { get; set; }

        [Required]
        [Column("HABILITADO")]
        public bool Habilitado { get; set; } = true;
    }
}
