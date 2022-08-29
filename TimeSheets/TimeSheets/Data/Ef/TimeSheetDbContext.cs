using Microsoft.EntityFrameworkCore;
using TimeSheets.Data.Configuration;
using TimeSheets.Models;

namespace TimeSheets.Data
{
    public class TimeSheetDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Sheet> Sheets { get; set; }
        public DbSet<Service> Services { get; set; }

        public TimeSheetDbContext(DbContextOptions<TimeSheetDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Client>().ToTable("Clients").HasOne(client => client.User);

            //modelBuilder.Entity<Contract>().ToTable("Contracts").HasOne(contract => contract.Client)
            //    .WithMany(client => client.Contracts)
            //    .HasForeignKey("ClientId");

            //modelBuilder.Entity<Employee>().ToTable("Employees").HasOne(employee => employee.User);

            //modelBuilder.Entity<Invoice>().ToTable("Invoices");

            //modelBuilder.Entity<Service>().ToTable("Services");

            //modelBuilder.Entity<Sheet>().ToTable("Sheets").Property(x => x.Id)
            //    .ValueGeneratedNever()
            //    .HasColumnName("Id");

            //modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Invoice)
            //    .WithMany(invoice => invoice.Sheets)
            //    .HasForeignKey("InvoiceId");

            //modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Contract)
            //    .WithMany(contract => contract.Sheets)
            //    .HasForeignKey("ContractId");

            //modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Service)
            //    .WithMany(service => service.Sheets)
            //    .HasForeignKey("ServiceId");

            //modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Employee)
            //    .WithMany(employee => employee.Sheets)
            //    .HasForeignKey("EmployeeId");

            //modelBuilder.Entity<User>().ToTable("Users");


            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new ContractConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new SheetConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
