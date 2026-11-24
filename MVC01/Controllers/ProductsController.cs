using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace MVC01.Controllers
{
    //[Route("/Test/[action]")]
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            // var result = new ViewResult();
            // return result;
            return View();
        }

        [HttpGet("Json")]
        public JsonResult GetJsonResults()
        {
            var products = new List<Models.Product>
            {
                new Models.Product { Id = 1, Name = "Laptop" },
                new Models.Product { Id = 2, Name = "Computer" },
                new Models.Product { Id = 3, Name = "Phone" }
            };
            return Json(products);
        }

        [HttpGet("ProductCode/{id}")]
        public IActionResult GetProducts(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            else if (id > 3)
            {
                return NotFound();
            }

            var products = new List<Models.Product>
            {
                new Models.Product { Id = 1, Name = "Laptop" },
                new Models.Product { Id = 2, Name = "Computer" },
                new Models.Product { Id = 3, Name = "Phone" }
            };
            return Json(products);
        }

        public RedirectToActionResult Redirect()
        {
            return RedirectToAction(nameof(GetProducts));
        }

        public ContentResult Content()
        {
            return Content("<h1>Hello from System</h1>", "text/html");
        }

        public RedirectResult RedirectToFacebook()
        {
            return Redirect("https://www.facebook.com");
        }

         public FileResult DownloadFile() 
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "css", "site.css");
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, contentType: "text/css", fileDownloadName: "MyCss. css");
        }


    }
}
