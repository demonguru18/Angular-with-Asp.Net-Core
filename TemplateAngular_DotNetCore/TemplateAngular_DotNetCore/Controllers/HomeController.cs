using Microsoft.AspNetCore.Mvc;

namespace TemplateAngular_DotNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
