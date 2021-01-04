﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HotelRoomDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter room name.")]
        public string Name { get; set; }

        [Range(1,300, ErrorMessage = "Invalid number of occupancy")]
        [Required(ErrorMessage = "Please enter occupancy.")]
        public int Occupancy { get; set; }
        public double RegularRate { get; set; }
        public string Details { get; set; }
        public string SqFt { get; set; }
    }
}
