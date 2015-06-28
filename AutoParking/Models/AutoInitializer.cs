using System.Data.Entity;

namespace AutoParking.Models
{
    public class AutoInitializer : DropCreateDatabaseAlways<AutoContext>
    {
        protected override void Seed(AutoContext context)
        {
            context.Users.Add(new User {Name = "Петров", Login = "admin", Password = "admin"});
            context.Parkings.Add(new Parking
            {
                Id = 1,
                Width = 5,
                Height = 10,
                Name = "Стоянка 1"
            });
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    context.ParkingPlaces.Add(new ParkingPlace
                    {
                        ParkingId = 1,
                        Row = i,
                        Column = j,
                        ParkingPlaceType = GetParkingPlaceType(j)
                    });
                }
            }
            context.SaveChanges();
        }

        private ParkingPlaceType GetParkingPlaceType(int j)
        {
            if (j <= 2) return ParkingPlaceType.Vip;
            if (j <= 4) return ParkingPlaceType.Middle;
            if (j <= 7) return ParkingPlaceType.Econom;
            return ParkingPlaceType.OnceOnly;
        }
    }
}
