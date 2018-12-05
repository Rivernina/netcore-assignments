using BellaSalon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BellaSalon.Data
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> option) : base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                  .HasKey(nameof(Appointment.ID));

            modelBuilder.Entity<Customer>()
                .HasKey(nameof(Customer.ID));

            modelBuilder.Entity<ServiceProvider>()
               .HasKey(nameof(ServiceProvider.ID));
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<ServiceProvider> ServiceProviders { set; get; }
    }
}
