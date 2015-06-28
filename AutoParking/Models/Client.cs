using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoParking.Models
{
    public class Client
    {
        [Browsable(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Имя")]
        [StringLength(100)]
        public string Name { get; set; }

        [DisplayName("Номер телефона")]
        [StringLength(40)]
        public string Phone { get; set; }

        [DisplayName("Автомобиль")]
        [StringLength(100)]
        public string Auto { get; set; }
    }
}
