namespace EmployeeWindowsApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeeModel : DbContext
    {
        public EmployeeModel()
            : base("name=EmployeeModel")
        {
        }

        public virtual DbSet<BasicBenefit> BasicBenefits { get; set; }
        public virtual DbSet<Benefit> Benefits { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Benefit>()
                .HasMany(e => e.BasicBenefits)
                .WithOptional(e => e.Benefit)
                .HasForeignKey(e => e.Benefits_Id);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Benefits)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.Employee_Id);
        }
    }
}
