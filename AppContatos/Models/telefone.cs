namespace AppContatos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_teste.telefone")]
    public partial class telefone
    {
        public int id { get; set; }

        public int id_pessoa { get; set; }

        [Required]
        [StringLength(1)]
        public string tipo { get; set; }

        [Required]
        [StringLength(2)]
        public string ddi { get; set; }

        [Required]
        [StringLength(3)]
        public string ddd { get; set; }

        [Column("telefone")]
        [Required]
        [StringLength(9)]
        public string telefone1 { get; set; }

        public virtual pessoa pessoa { get; set; }
    }
}
