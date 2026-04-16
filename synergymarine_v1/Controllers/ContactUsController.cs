using Microsoft.AspNetCore.Mvc;

namespace synergymarine_v1.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
