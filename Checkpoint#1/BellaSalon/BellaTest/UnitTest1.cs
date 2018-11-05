using System;
using BellaSalon.Models;
using BellaSalon.Controllers;
using Xunit;
using BellaSalon;

namespace BellaTests
{
    public class ControllerTest
    {
        [Fact]
        public void Controller_ShouldCreateServiceProvider()
        {
            var controller = new HomeController();
            var serviceProvider = new ServiceProvider();

            controller.ServiceProviderCreate(serviceProvider);

            Assert.NotEmpty(Repository.ServiceProviders);
        }
    }
}
