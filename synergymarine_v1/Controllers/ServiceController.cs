using Microsoft.AspNetCore.Mvc;

namespace synergymarine_v1.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult CapabilitySpectrum()
        {
            return View();
        }


        public IActionResult Clients()
        {
            return View();
        }
    }
}
