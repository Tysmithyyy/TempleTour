using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTour.Models
{
    public class ITempleTourRepository
    {
        IQueryable<Appointment> Appointments { get; }
    }
}
