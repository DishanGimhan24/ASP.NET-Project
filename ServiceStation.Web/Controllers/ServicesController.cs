using Microsoft.AspNetCore.Mvc;
using ServiceStation.Web.Models;

namespace ServiceStation.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            var service = new VehicleService
            {
                Id = 1,
                Title = "Test",
                Description = "Test",
                Cost = 1


            };




            return View(service);
        } 

    }
}
