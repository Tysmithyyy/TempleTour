using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleTour.Models;
using TempleTour.Models.ViewModels;

namespace TempleTour.Controllers
{
    public class HomeController : Controller
    {
        //set up for repository for the time slots
        private readonly ILogger<HomeController> _logger;

        private ITempleTourRepository _repository;

        
        //set up for the db context for the appointments
        private TempleTourDbContext context { get; set; }

        //added to receive the Itimeslotrepostory
        public HomeController(ILogger<HomeController> logger, ITempleTourRepository repository, TempleTourDbContext con)
        {
            _logger = logger;
            
            //added, repository for all avaialble time slots, context for made appointments
            _repository = repository;
            context = con;
        }

       
        //VIEW ACTIONS

        //index view
        public IActionResult Index()
        {
            return View();
        }

        //sign up view, pass the timeslots that are available
        public IActionResult Signup()
        {

           //only bring in timslots that are available
            return View(new TimeslotListViewModel
            {
                Timeslots = _repository.Timeslots
                    .Where(t => t.Available == "Available")
                    .OrderBy(t => t.TimeslotId)
            });

        }

        [HttpPost]
        public IActionResult Signup(string time, string date)
        {
            //set appointment with form information
            var appointment = new Appointment
            {
                Time = time,
                Date = date
            };

            //change timeslot availibility to "unavailable" so that it is not included on the sign up page one the time slot has been booked
            Timeslot someTime = new Timeslot();
            someTime = _repository.Timeslots
                .Where(t => t.Time == time && t.Date == date)
                .OrderBy(t => t.TimeslotId).FirstOrDefault();

            someTime.Available = "unavailable";

            //update changes to database --changes to unavailable
            context.Update(someTime);
            context.SaveChanges();

            return View("Form", appointment);
        }


        //when the "sign up" button is pressed, the appointment is appended onto  the dbcontext of appointments

        [HttpPost]
        public IActionResult Form(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                //update data entered is valid, if not, return the asp-validation summary
                context.Appointments.Add(appointment);                             
                context.SaveChanges();

            }

            //after appointment is added to list of appointments, redirect to the ViewAppointments page
            return RedirectToAction("ViewAppointments");
        }



        //form view
        public IActionResult Form()
            {

                //allow user to fill out form based on the appointment that they chose
                return View();
            }

        

        //View Appointments view
        public IActionResult ViewAppointments()
        {
            //return the list of all appointments that have been booked by the user
            return View(new AppointmentListViewModel
            {
                Appointments = _repository.Appointments
                    .OrderBy(t => t.AppointmentId)
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
