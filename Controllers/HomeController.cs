﻿using Microsoft.AspNetCore.Mvc;
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
            var appointment = new Appointment
            {
                Time = time,
                Date = date
            };
            Timeslot someTime = new Timeslot();
            someTime = _repository.Timeslots
                .Where(t => t.Time == time && t.Date == date)
                .OrderBy(t => t.TimeslotId).FirstOrDefault();

            someTime.Available = "unavailable";

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
            return RedirectToAction("ViewAppointments");
            //return View("ViewAppointments", );
        }



        //form view
        public IActionResult Form()
            {

                //return the list of all appointments
                return View();
            }

        

        //View Appointments view
        public IActionResult ViewAppointments()
        {
            //return the list of all appointments
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
