using ElectricVehiclesBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElectricVehiclesBackend.Infrastructure
{
    public class ElectricVehiclesBackendDbContext : DbContext
    {
        public ElectricVehiclesBackendDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Vehicle> Vehicles {  get; set; }
        
        public DbSet<VehicleType> VehicleTypes { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Rental> Rentals { get; set; }
    }
}
