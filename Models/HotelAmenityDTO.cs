using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HotelAmenityDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter timming")]
        public string Timming { get; set; }
        public string IconStyle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}
