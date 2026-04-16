using Microsoft.AspNetCore.Mvc;

namespace synergymarine_v1.Controllers
{
    public class FleetController : Controller
    {
        public IActionResult FleetOverview()
        {
            return View();
        }

        public IActionResult OurFleetSpecifications()
        {
            return View();
        }
    }
}
