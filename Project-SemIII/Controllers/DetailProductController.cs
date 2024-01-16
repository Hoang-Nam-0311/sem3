using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Sem3.Models;

namespace Project_SemIII.Controllers
{
    public class DetailProductController : Controller
    {
        private readonly ProjectDbContext _context;

        public DetailProductController(ProjectDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync(int id)
        {
            Product product = await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
            List<Product> productList = new List<Product> { product };
            return View(productList);
        }
    }
}
