using Microsoft.AspNetCore.Mvc;

namespace NewSolution.Controllers.ContactUs
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
