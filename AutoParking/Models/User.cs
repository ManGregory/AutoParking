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
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        [Browsable(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Имя пользователя")]
        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [DisplayName("Логин пользователя")]
        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string Login { get; set; }

        [DisplayName("Пароль")]
        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
