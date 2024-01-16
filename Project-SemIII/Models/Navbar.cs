using Microsoft.AspNetCore.Mvc;
using Project_Sem3.Models;

namespace Project_SemIII.Models
{
    public class Navbar : ViewComponent
    {
        private readonly ProjectDbContext _context;

        public Navbar(ProjectDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Category.ToList());
        }
    }
}
