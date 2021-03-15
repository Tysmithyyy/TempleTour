using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTour.Models
{
    public class TempleTourDbContext : DbContext
    {
        public TempleTourDbContext (DbContextOptions<TempleTourDbContext> options) : base (options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
