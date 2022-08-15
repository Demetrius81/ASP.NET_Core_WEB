using Microsoft.EntityFrameworkCore;
using TimeSheets.Models;

namespace TimeSheets.Data
{
    public class TimeSheetDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Sheet> Sheets { get; set; }
        public DbSet<Service> Services { get; set; }

        public TimeSheetDbContext(DbContextOptions<TimeSheetDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            //modelBuilder.Entity<Service>().ToTable("Services");
            //modelBuilder.Entity<Client>().ToTable("Clients");
            //modelBuilder.Entity<Employee>().ToTable("Employees");
            //modelBuilder.Entity<Contract>().ToTable("Contracts");
            //modelBuilder.Entity<Sheet>().ToTable("Sheets");

            modelBuilder.Entity<Service>().HasOne(service => service.Contract)
                .WithMany(contract => contract.Services)
                .HasForeignKey("ContractId");

            modelBuilder.Entity<Employee>().HasOne(employee => employee.User);

            modelBuilder.Entity<Client>().HasOne(client => client.User);

            modelBuilder.Entity<Contract>().HasOne(contract => contract.Client)
                .WithMany(client => client.Contracts)
                .HasForeignKey("ClientId");

            modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Contract)
                .WithMany(contract => contract.Sheets)
                .HasForeignKey("ContractId");

            modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Service)
                .WithMany(service => service.Sheets)
                .HasForeignKey("ServiceId");

            modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Employee)
                .WithMany(employee => employee.Sheets)
                .HasForeignKey("EmployeeId");

        }
    }
}
