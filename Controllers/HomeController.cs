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
        private readonly ILogger<HomeController> _logger;

        private ITempleTourRepository _repository;

        //added to receive the Itimeslotrepostory
        public HomeController(ILogger<HomeController> logger, ITempleTourRepository repository)
        {
            _logger = logger;
            //added
            _repository = repository;
        }

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

        //form view
        public IActionResult Form()
        {
            return View();
        }

        //View Appointments view
        public IActionResult ViewAppointments()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
