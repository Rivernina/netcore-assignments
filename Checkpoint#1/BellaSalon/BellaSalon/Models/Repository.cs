using BellaSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BellaSalon
{
    public static class Repository
    {
        private static List<Appointment> appointments = new List<Appointment>();
        private static List<Customer> customers = new List<Customer>();
        private static List<ServiceProvider> serviceProviders = new List<ServiceProvider>();
        //private static List<AppointmentResponse> responses = new List<AppointmentResponse>();

        //public static IEnumerable<AppointmentResponse> Responses
        //{
        //    get
        //    {
        //        return responses;
        //    }
        //}

        //public static void AddResponse(AppointmentResponse response)
        //{
        //    responses.Add(response);
        //}
        public static void AddAppointment(Appointment appointment)
        {

            appointments.Add(appointment);  
        }


        public static void CustomerAdd(Customer customer)
        {

            customers.Add(customer);
        }

        public static void ServiceProviderAdd(ServiceProvider serviceProvider)
        {

            serviceProviders.Add(serviceProvider);
        }

        public static void CustomerRemove(Customer customer)
        {
            customers.Remove(customer);
        }

        public static void ServiceProviderRemove(ServiceProvider serviceProvider)
        {
            serviceProviders.Remove(serviceProvider);
        }

        public static void AppointmentRemove(Appointment appointment)
        {
            appointments.Remove(appointment);
        }

        public static IEnumerable<Appointment> Appointments
        {
            get
            {
                return appointments;
            }
        }

        public static IEnumerable<Customer> Customers
        {
            get
            {
                return customers;
            }
        }

        public static IEnumerable<ServiceProvider> ServiceProviders
        {
            get
            {
                return serviceProviders;
            }
        }
    }
}
