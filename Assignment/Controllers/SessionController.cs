using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SetSession()
        {
            HttpContext.Session.SetInt32("Id", 1);
            HttpContext.Session.SetString("Name", "Mousa");
            return Content("Data saved");
        }

        public IActionResult GetSession()
        {
            int? Id = HttpContext.Session.GetInt32("Id");
            string Name = HttpContext.Session.GetString("Name");
            return Content("Id " + Id + " Name " + Name);
        }


    }
}
