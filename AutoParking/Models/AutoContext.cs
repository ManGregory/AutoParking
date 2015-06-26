using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParking.Models
{
    public class AutoContext : DbContext
    {
        public AutoContext() : base("DefaultConnectionString")
        {            
        }

        public DbSet<User> Users { get; set; }
    }
}
