using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoParking.Models
{
    public class Order
    {
        [Browsable(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Browsable(false)]
        [DisplayName("Дата регистрации")]
        public DateTime RegistrationDate { get; set; }

        [DisplayName("Въезд")]
        public DateTime FromDate { get; set; }

        [DisplayName("Выезд")]
        public DateTime ToDate { get; set; }

        [DisplayName("Фактический выезд")]
        public DateTime FactToDate { get; set; }

        [Browsable(false)]
        public int? ClientId { get; set; }
        [DisplayName("Клиент")]
        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        [Browsable(false)]
        public int ParkingPlaceId { get; set; }
        [DisplayName("Стояночное место")]
        [ForeignKey("ParkingPlaceId")]
        public ParkingPlace ParkingPlace { get; set; }

        [Browsable(false)]
        public ParkingPlaceStatus ParkingPlaceStatus { get; set; }

        [DisplayName("Тип места")]
        public ParkingPlaceType ParkingPlaceType { get; set; }

        [DisplayName("Тариф")]
        public decimal Rate { get; set; }

        [DisplayName("К оплате")]
        public decimal MustPay { get; set; }

        [DisplayName("Оплачено")]
        public decimal Pay { get; set; }

        [Browsable(false)]
        public decimal Cost { get; set; }

        [Browsable(false)]
        public decimal Inflation { get; set; }

        [Browsable(false)]
        public decimal C { get; set; }

        [Browsable(false)]
        public decimal M { get; set; }

        [Browsable(false)]
        public decimal V { get; set; }

        [Browsable(false)]
        public decimal S { get; set; }
    }
}
