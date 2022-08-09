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
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Contract>().ToTable("Contracts");
            modelBuilder.Entity<Sheet>().ToTable("Sheets");
            modelBuilder.Entity<Service>().ToTable("Services");
        }
    }
}
