using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTour.Models
{
    public class EFTEmpleTourRepository : ITempleTourRepository
    {
        private TempleTourDbContext _context;

        public EFTEmpleTourRepository (TempleTourDbContext context)
        {
            _context = context;
        }

        public IQueryable<Appointment> Appointments => _context.Appointments;
    }
}
