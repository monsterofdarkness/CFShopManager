namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int id { get; set; }

        [StringLength(50)]
        public string NameCustomer { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateAt { get; set; }

        [StringLength(200)]
        public string Adress { get; set; }

        [Required]
        [StringLength(11)]
        public string Phone { get; set; }

        public int TypeCustomer { get; set; }
    }
}
