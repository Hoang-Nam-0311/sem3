using Microsoft.AspNetCore.Mvc;
using Project_Sem3.Models;

namespace Project_SemIII.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProjectDbContext _context;

        public ProductController(ProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }

    }
}
