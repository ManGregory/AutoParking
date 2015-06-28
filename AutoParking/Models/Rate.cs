using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoParking.Models
{
    public class Rate
    {
        [Browsable(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public ParkingPlaceType ParkingPlaceType { get; set; }

        public decimal Value { get; set; }
    }
}
