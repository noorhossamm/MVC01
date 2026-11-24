using Microsoft.AspNetCore.Mvc;

namespace MVC01.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetMembers(int id)
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }


    }
}
