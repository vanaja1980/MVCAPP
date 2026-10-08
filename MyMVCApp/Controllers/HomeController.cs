using Microsoft.AspNetCore.Mvc;

namespace MyMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var method = HttpContext.Request.Method;
            return View("Index");
        }

        public string Error()
        {
            return "Hello Error";
        }
    }
}
