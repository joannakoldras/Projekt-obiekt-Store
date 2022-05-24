using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Projekt_Obiekt.DbModelds
{
    [Table("Brands")]
    public class Brand
    {
        [Column("BrandId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string BrandName { get; set; }
    }
}
