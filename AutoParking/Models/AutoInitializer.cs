using System.Data.Entity;

namespace AutoParking.Models
{
    public class AutoInitializer : DropCreateDatabaseAlways<AutoContext>
    {
        protected override void Seed(AutoContext context)
        {
            context.Users.Add(new User {Name = "Петров", Login = "admin", Password = "admin"});
            context.SaveChanges();
        }
    }
}
