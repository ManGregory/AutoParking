using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParking.Models
{
    public class Order
    {
        [Browsable(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public DateTime FactToDate { get; set; }

        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public int ParkingPlaceId { get; set; }
        [ForeignKey("ParkingPlaceId")]
        public ParkingPlace ParkingPlace { get; set; }

        public ParkingPlaceStatus ParkingPlaceStatus { get; set; }

        public ParkingPlaceType ParkingPlaceType { get; set; }

        public decimal MustPay { get; set; }

        public decimal Pay { get; set; }
    }
}
