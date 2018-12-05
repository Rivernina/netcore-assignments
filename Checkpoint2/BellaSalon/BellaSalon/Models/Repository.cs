using BellaSalon.Data;
using BellaSalon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BellaSalon
{
    internal class Repository
    {
        public void AddAppointment(Appointment appointment, ApplicationContext context)
        {
            appointment.Customer = context.Customers.FirstOrDefault(c => c.ID == appointment.CustomerId);
            appointment.ServiceProvider = context.ServiceProviders.FirstOrDefault(s => s.ID == appointment.ServiceProviderId);
            context.Appointments.Add(appointment);
            context.SaveChanges();
        }


        public void CustomerAdd(Customer customer, ApplicationContext context)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void ServiceProviderAdd(ServiceProvider serviceProvider, ApplicationContext context)
        {
            context.ServiceProviders.Add(serviceProvider);
            context.SaveChanges();
        }

        public void CustomerRemove(Customer customer, ApplicationContext context)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }
        public void ServiceProviderRemove(ServiceProvider serviceProvider, ApplicationContext context)
        {
            context.ServiceProviders.Remove(serviceProvider);
            context.SaveChanges();
        }
        public void AppointmentRemove(Appointment appointment, ApplicationContext context)
        {
            appointment.Customer = context.Customers.FirstOrDefault(c => c.ID == appointment.CustomerId);
            appointment.ServiceProvider = context.ServiceProviders.FirstOrDefault(s => s.ID == appointment.ServiceProviderId);
            context.Appointments.Remove(appointment);
            context.SaveChanges();
        }
    }
}
