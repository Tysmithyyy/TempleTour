using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTour.Models
{
    public class Timeslot
    {
        [Required]
        public int TimeslotId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        //availability will be set to "Available" in seed data, then as it is booked, it will be changed to Unavailable
        public string Available { get; set; }

    }
}
