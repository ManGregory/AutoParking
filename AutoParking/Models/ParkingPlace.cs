using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoParking.Models
{
    public enum ParkingPlaceType
    {
        OnceOnly = 1,
        Econom = 2,
        Middle = 3,
        Vip = 4
    }

    public enum ParkingPlaceStatus
    {
        Free = 1,
        Reservated = 2,
        Busy = 3
    }

    public class ParkingPlace
    {
        [Browsable(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ParkingId { get; set; }
        [ForeignKey("ParkingId")]
        public Parking Parking { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public ParkingPlaceType ParkingPlaceType { get; set; }

        [NotMapped]
        public ParkingPlaceStatus ParkingPlaceStatus { get; set; }

        public static string ConvertParkingPlaceType(ParkingPlaceType parkingPlaceType)
        {
            if (parkingPlaceType == ParkingPlaceType.OnceOnly) return "Разовый";
            if (parkingPlaceType == ParkingPlaceType.OnceOnly) return "Эконом";
            if (parkingPlaceType == ParkingPlaceType.OnceOnly) return "Средний";
            return "VIP";
        }

        public override string ToString()
        {
            return string.Format("Стояночное место {0} ({1},{2})", ConvertParkingPlaceType(ParkingPlaceType), Row,
                Column);
        }
    }
}
