using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Controllers
{
    public class SocialMediaViewComponent : ViewComponent
    {
        public SocialMediaViewComponent()
        {
        }
        public IViewComponentResult Invoke(string socialMediaType)
        {
            return View("Default", socialMediaType);
        }
    }
}
