﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoParking.Models
{
    public class Parking
    {
        [Browsable(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public decimal Cost { get; set; }
    }
}
