namespace WindowsFormsApp1.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DBCFS")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeePayroll> EmployeePayrolls { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<TableCF> TableCFs { get; set; }
        public virtual DbSet<BillInfo> BillInfoes { get; set; }
        public virtual DbSet<Revenue> Revenues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BillInfoes)
                .WithRequired(e => e.Bill)
                .HasForeignKey(e => e.idBill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bill>()
                .HasOptional(e => e.Revenue)
                .WithRequired(e => e.Bill);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.idCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.idCus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.idEm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeePayrolls)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.idEm);

            modelBuilder.Entity<TableCF>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.TableCF)
                .HasForeignKey(e => e.idTable)
                .WillCascadeOnDelete(false);
        }
    }
}
