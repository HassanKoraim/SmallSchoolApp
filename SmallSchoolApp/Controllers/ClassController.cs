using Microsoft.AspNetCore.Mvc;

namespace SmallSchoolApp.Controllers
{
    public class ClassController : Controller
    {
        [Route("/class")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/class/{className:string}")]
        public IActionResult Index(string className)
        {
            return View();
        }
    }
}
