namespace Academico2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Professor")]
    public partial class Professor
    {
        public int ID { get; set; }

        [Required]
        [StringLength(70)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public string Cpf { get; set; }

        public string Biografia { get; set; }
    }
}
