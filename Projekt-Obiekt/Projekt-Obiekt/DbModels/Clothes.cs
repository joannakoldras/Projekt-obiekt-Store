using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Obiekt.DbModelds
{
    public class Clothes
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public virtual Category Id_Category { get; set; }
        public virtual Brand Id_Brand { get; set; }
        public virtual Color Id_Color { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
