using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTour.Models.ViewModels
{
    public class AppointmentListViewModel
    {
        public IEnumerable<Appointment> Appointments { get; set; }
    }

}
