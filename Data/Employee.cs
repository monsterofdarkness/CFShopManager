namespace WindowsFormsApp1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Bills = new HashSet<Bill>();
            EmployeePayrolls = new HashSet<EmployeePayroll>();
        }

        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DoB { get; set; }

        [StringLength(50)]
        public string NameEmployee { get; set; }

        public int Sex { get; set; }

        [StringLength(20)]
        public string Position { get; set; }

        public double? BasicSalary { get; set; }

        public int TypeStaff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeePayroll> EmployeePayrolls { get; set; }
    }
}
