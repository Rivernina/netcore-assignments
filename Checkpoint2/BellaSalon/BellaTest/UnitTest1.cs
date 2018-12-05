using System;
using BellaSalon.Models;
using BellaSalon.Controllers;
using Xunit;
using BellaSalon;
using BellaSalon.Data;
using Microsoft.EntityFrameworkCore;

namespace BellaTests
{
    public class ControllerTest
    {
        [Fact]
        public void Controller_ShouldCreateServiceProvider()
        {
            var context = new ApplicationContext(DbAssembly().Options);
            var controller = new HomeController(context);
            var serviceProvider = new ServiceProvider();

            controller.ServiceProviderCreate(serviceProvider);


            Assert.NotEmpty(context.ServiceProviders);
        }
        public DbContextOptionsBuilder<ApplicationContext> DbAssembly()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseInMemoryDatabase();
            return optionsBuilder;
        }
    }
}
