namespace WindowsFormsApp1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Revenue")]
    public partial class Revenue
    {
        [Column(TypeName = "date")]
        public DateTime? DMY { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idBill { get; set; }

        public double? allMoney { get; set; }

        public virtual Bill Bill { get; set; }
    }
}
