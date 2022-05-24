using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Projekt_Obiekt.DbModelds
{
    [Table("ClothesStore")]
    public class Clothes
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Id_Category { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brand Id_Brand { get; set; }

        [ForeignKey("ColorId")]
        public virtual Color Id_Color { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
