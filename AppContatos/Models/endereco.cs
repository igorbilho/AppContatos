using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContatos.Models
{
    [Table("db_teste.endereco")]
    public partial class endereco
    {
        public int id { get; set; }

        public int id_pessoa { get; set; }

        [Required]
        public string numero { get; set; }

        [Column("endereco")]
        [Required]
        [StringLength(500)]
        public string endereco1 { get; set; }

        [Required]
        [StringLength(200)]
        public string complemento { get; set; }

        public virtual pessoa pessoa { get; set; }
    }
}
