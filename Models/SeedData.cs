using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTour.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            TempleTourDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TempleTourDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //if there is not currently context this will seed the database with initial data
            if (!context.Timeslots.Any())
            {
                context.Timeslots.AddRange(

                    new Timeslot
                    {
                        TimeslotId= 1,
                        Date="3/22/2021",
                        Time="8:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 2,
                        Date = "3/22/2021",
                        Time = "9:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 3,
                        Date = "3/22/2021",
                        Time = "10:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 4,
                        Date = "3/22/2021",
                        Time = "11:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 5,
                        Date = "3/22/2021",
                        Time = "12:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 6,
                        Date = "3/22/2021",
                        Time = "1:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 7,
                        Date = "3/22/2021",
                        Time = "2:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 8,
                        Date = "3/22/2021",
                        Time = "3:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 9,
                        Date = "3/22/2021",
                        Time = "4:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 10,
                        Date = "3/22/2021",
                        Time = "5:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 11,
                        Date = "3/22/2021",
                        Time = "6:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 12,
                        Date = "3/22/2021",
                        Time = "7:00 pm"
                    },
                    new Timeslot
                    {
                    TimeslotId = 13,
                        Date = "3/23/2021",
                        Time = "8:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 14,
                        Date = "3/23/2021",
                        Time = "9:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 15,
                        Date = "3/23/2021",
                        Time = "10:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 16,
                        Date = "3/23/2021",
                        Time = "11:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 17,
                        Date = "3/23/2021",
                        Time = "12:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 181,
                        Date = "3/23/2021",
                        Time = "1:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 19,
                        Date = "3/23/2021",
                        Time = "2:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 20,
                        Date = "3/23/2021",
                        Time = "3:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 21,
                        Date = "3/23/2021",
                        Time = "4:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 22,
                        Date = "3/23/2021",
                        Time = "5:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 23,
                        Date = "3/23/2021",
                        Time = "6:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 24,
                        Date = "3/23/2021",
                        Time = "7:00 pm"
                    },
                    new Timeslot
                    {
                    TimeslotId = 25,
                        Date = "3/24/2021",
                        Time = "8:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 26,
                        Date = "3/24/2021",
                        Time = "9:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 27,
                        Date = "3/24/2021",
                        Time = "10:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 28,
                        Date = "3/24/2021",
                        Time = "11:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 29,
                        Date = "3/24/2021",
                        Time = "12:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 30,
                        Date = "3/24/2021",
                        Time = "1:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 31,
                        Date = "3/24/2021",
                        Time = "2:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 32,
                        Date = "3/24/2021",
                        Time = "3:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 33,
                        Date = "3/24/2021",
                        Time = "4:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 34,
                        Date = "3/24/2021",
                        Time = "5:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 35,
                        Date = "3/24/2021",
                        Time = "6:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 36,
                        Date = "3/24/2021",
                        Time = "7:00 pm"
                    },
                    new Timeslot
                    {
                    TimeslotId = 37,
                        Date = "3/25/2021",
                        Time = "8:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 38,
                        Date = "3/25/2021",
                        Time = "9:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 39,
                        Date = "3/25/2021",
                        Time = "10:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 40,
                        Date = "3/25/2021",
                        Time = "11:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 41,
                        Date = "3/25/2021",
                        Time = "12:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 42,
                        Date = "3/25/2021",
                        Time = "1:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 43,
                        Date = "3/25/2021",
                        Time = "2:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 44,
                        Date = "3/25/2021",
                        Time = "3:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 45,
                        Date = "3/25/2021",
                        Time = "4:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 46,
                        Date = "3/25/2021",
                        Time = "5:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 47,
                        Date = "3/25/2021",
                        Time = "6:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 48,
                        Date = "3/25/2021",
                        Time = "7:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 49,
                        Date = "3/26/2021",
                        Time = "8:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 50,
                        Date = "3/26/2021",
                        Time = "9:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 51,
                        Date = "3/26/2021",
                        Time = "10:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 52,
                        Date = "3/26/2021",
                        Time = "11:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 53,
                        Date = "3/26/2021",
                        Time = "12:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 54,
                        Date = "3/26/2021",
                        Time = "1:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 55,
                        Date = "3/26/2021",
                        Time = "2:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 56,
                        Date = "3/26/2021",
                        Time = "3:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 57,
                        Date = "3/26/2021",
                        Time = "4:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 58,
                        Date = "3/26/2021",
                        Time = "5:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 59,
                        Date = "3/26/2021",
                        Time = "6:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 60,
                        Date = "3/26/2021",
                        Time = "7:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 61,
                        Date = "3/27/2021",
                        Time = "8:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 62,
                        Date = "3/27/2021",
                        Time = "9:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 63,
                        Date = "3/27/2021",
                        Time = "10:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 64,
                        Date = "3/27/2021",
                        Time = "11:00 am"
                    },
                    new Timeslot
                    {
                        TimeslotId = 65,
                        Date = "3/27/2021",
                        Time = "12:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 66,
                        Date = "3/27/2021",
                        Time = "1:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 67,
                        Date = "3/27/2021",
                        Time = "2:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 68,
                        Date = "3/27/2021",
                        Time = "3:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 69,
                        Date = "3/27/2021",
                        Time = "4:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 70,
                        Date = "3/27/2021",
                        Time = "5:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 71,
                        Date = "3/27/2021",
                        Time = "6:00 pm"
                    },
                    new Timeslot
                    {
                        TimeslotId = 72,
                        Date = "3/27/2021",
                        Time = "7:00 pm"
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
}
