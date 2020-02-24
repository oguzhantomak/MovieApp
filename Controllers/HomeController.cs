using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
        public IActionResult Contact()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
    }
}