using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTour.Models
{
    public interface ITempleTourRepository
    {
        IQueryable<Appointment> Appointments { get; }
        IQueryable<Timeslot> Timeslots { get; }
    }
}
