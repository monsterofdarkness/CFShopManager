namespace WindowsFormsApp1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeePayroll")]
    public partial class EmployeePayroll
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DMYofW { get; set; }

        public int? idEm { get; set; }

        public int? NumofWorks { get; set; }

        public double? Bonus { get; set; }

        public double? Salary { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
