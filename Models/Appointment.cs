using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTour.Models
{
    public class Appointment
    {
        [Required]
        public int AppointmentId { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        public string EmailAddress { get; set; }

        //phone number set as string so it can be validated usign the tag helper on Form.cshtml
        public string PhoneNumber { get; set; }
    }
}
