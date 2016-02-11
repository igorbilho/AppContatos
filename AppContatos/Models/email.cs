using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContatos.Models
{
    [Table("db_teste.email")]
    public partial class email
    {
        public int id { get; set; }

        public int id_pessoa { get; set; }

        [Required]
        [StringLength(1)]
        public string tipo { get; set; }

        [Column("email")]
        [Required]
        [StringLength(300)]
        public string email1 { get; set; }

        public virtual pessoa pessoa { get; set; }
    }
}
