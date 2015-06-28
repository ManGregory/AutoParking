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
    }
}
