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
            MovieCategoryModel model = new MovieCategoryModel();
            model.Categories=CategoryRepository.Categories;
            model.Movies=MovieRepository.Movies;
            
            return View(model);
        }

        public IActionResult Details(int id)
        {

            MovieCategoryModel model = new MovieCategoryModel();
            model.Categories=CategoryRepository.Categories;
            model.Movie=MovieRepository.GetById(id);
            return View(model);
        }
        
        public IActionResult Contact()
        {
          return View();
        }
    }
}