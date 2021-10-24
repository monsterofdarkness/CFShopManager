namespace WindowsFormsApp1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int id { get; set; }

        [Required]
        [StringLength(69)]
        public string nameProduct { get; set; }

        public int idCategory { get; set; }

        public double priceProduct { get; set; }

        public virtual Category Category { get; set; }
    }
}
