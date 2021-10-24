namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STAFF")]
    public partial class STAFF
    {
        public int id { get; set; }

        [StringLength(50)]
        public string NameSTAFF { get; set; }

        [StringLength(20)]
        public string Position { get; set; }

        public int Age { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        public double? Salary { get; set; }

        public int TypeStaff { get; set; }
    }
}
