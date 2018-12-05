using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BellaSalon.Models;
using BellaSalon.Data;

namespace BellaSalon.Controllers
{
    public class HomeController : Controller
    {
        Repository repository = new Repository();

        private ApplicationContext context;
        public HomeController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult CustomerIndex()
        {
            return View(context.Customers);
        }
        [HttpGet]
        public IActionResult CustomerCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CustomerCreate(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            repository.CustomerAdd(customer, context);
            return View("CustomerIndex", context.Customers);
        }
        public IActionResult CustomerDelete(Guid ID)
        {
            var DelCustomer = context.Customers.ToList().Find(c => c.ID == ID);
            if (!context.Appointments.Any(a => a.Customer == DelCustomer))
                {
                    repository.CustomerRemove(DelCustomer, context);
                }
            else
            {
                ViewBag.error = "You cannot delete customer with outstanding appointments.";
            }
            return View("CustomerIndex", context.Customers);
        }
        public IActionResult ServiceProviderIndex()
        {
            return View(context.ServiceProviders);
        }
        [HttpGet]
        public IActionResult ServiceProviderCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ServiceProviderCreate(ServiceProvider serviceProvider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            repository.ServiceProviderAdd(serviceProvider, context);
            return View("ServiceProviderIndex", context.ServiceProviders);
        }
        public IActionResult ServiceProviderDelete(Guid ID)
        {
            var DelServiceProvider = context.ServiceProviders.ToList().Find(s => s.ID == ID);
            if (!context.Appointments.Any(a => a.ServiceProvider == DelServiceProvider))
            {
                repository.ServiceProviderRemove(DelServiceProvider, context);
            }
            else
            {
                ViewBag.error = "You cannot delete service provider with outstanding appointments.";
            }
            return View("ServiceProviderIndex", context.ServiceProviders);
        }
        public IActionResult AppointmentsByDate(Guid ID)
        {
            var SPAppointments = context.Appointments.Where(a => a.ServiceProviderId == ID).ToList();

            ViewBag.SPAppointments = SPAppointments.OrderBy(a => a.Date).ThenBy(a => a.Time).ToList();
            ViewBag.ServiceProviderName = context.ServiceProviders.FirstOrDefault(a => a.ID == ID).Name;
            ViewBag.Customers = context.Customers.ToList();
            return View();
        }
        public IActionResult AppointmentIndex()
        {
            ViewBag.ServiceProviders = context.ServiceProviders.ToList();
            ViewBag.Customers = context.Customers.ToList();
            return View(context.Appointments.OrderBy(a => a.Date));
        }
        [HttpGet]
        public IActionResult AppointmentCreate()
        {
            ViewBag.ServiceProviders = context.ServiceProviders.ToList();
            ViewBag.Customers = context.Customers.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AppointmentCreate(Appointment appointment)
        {
            bool custExists = false;
            bool serviceProviderExists = false;
            bool doubleBooked = false;
            foreach (var c in context.Customers)
            {
                if (appointment.CustomerId == c.ID)
                    custExists = true;
            }
            foreach (var s in context.ServiceProviders)
            {
                if (appointment.ServiceProviderId == s.ID)
                    serviceProviderExists = true;
            }
            foreach (var a in context.Appointments)
            {
                if (appointment.Date == a.Date && appointment.Time == a.Time && (appointment.Customer == a.Customer || appointment.ServiceProvider == a.ServiceProvider))
                {
                    doubleBooked = true;
                }
            }
            if (custExists && serviceProviderExists && !doubleBooked)
            {
                repository.AddAppointment(appointment, context); 
            }
            else
            {
                ViewBag.error = "Invalid Appointment";
            }
            return View("AppointmentIndex", context.Appointments.OrderBy(a => a.Date).ThenBy(a => a.Time));
        }

        public IActionResult AppointmentDelete(Guid ID)
        {
            var DelAppointment = context.Appointments.ToList().Find(a => a.ID == ID);
            repository.AppointmentRemove(DelAppointment, context);
            ViewBag.ServiceProviders = context.ServiceProviders.ToList();
            ViewBag.Customers = context.Customers.ToList();
            return View("AppointmentIndex", context.Appointments);
        }

        public IActionResult Index()
        {
            ViewData["message"] = "Bella's Spa and Nails";
            return View("BellaSalon");
        }

        public IActionResult Home()
        {
            return View("Home");
        }
        

    }
}

