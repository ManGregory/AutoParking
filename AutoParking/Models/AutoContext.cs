using System.Data.Entity;

namespace AutoParking.Models
{
    public class AutoContext : DbContext
    {
        public AutoContext() : base("DefaultConnectionString")
        {            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<ParkingPlace> ParkingPlaces { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Inflation> Inflations { get; set; }
    }
}
