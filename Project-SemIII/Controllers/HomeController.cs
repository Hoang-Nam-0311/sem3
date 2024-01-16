using Microsoft.AspNetCore.Mvc;
using Project_Sem3.Models;
using Project_SemIII.Models;
using System.Diagnostics;

namespace Project_SemIII.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectDbContext _context;

        public HomeController(ProjectDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}