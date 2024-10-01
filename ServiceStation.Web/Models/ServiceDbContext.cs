using Microsoft.EntityFrameworkCore;

namespace ServiceStation.Web.Models
{
    public class ServiceDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<VehicleService> VehicleServices { get; set; }




        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           var connectionString =@"Server=(localdb)\MSSQLLocaldb;Database=ServiceStation;Trusted_Connection=True; ";

            optionsBuilder.UseSqlServer(connectionString);
         
        }

    }

}
