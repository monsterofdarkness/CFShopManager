namespace WindowsFormsApp1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BillInfoes = new HashSet<BillInfo>();
        }

        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCheckIn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCheckOut { get; set; }

        public int idEm { get; set; }

        public int idCus { get; set; }

        public int idTable { get; set; }

        public double? Discount { get; set; }

        public double? PriceBill { get; set; }

        public double? Amount { get; set; }

        public int statusBill { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual TableCF TableCF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfoes { get; set; }

        public virtual Revenue Revenue { get; set; }
    }
}
