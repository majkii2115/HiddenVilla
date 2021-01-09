using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class HotelAmenity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Timming { get; set; }
        public string IconStyle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}
