using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(ProductRepository.Movies);
        }

        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetById(id));
        }
        
        public IActionResult Contact()
        {
          return View();
        }
    }
}