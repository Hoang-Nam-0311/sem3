using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Sem3.Models;
using System.Collections.Generic;
namespace Project_SemIII.Controllers
{
    public class SearchProductController : Controller
    {
        private readonly ProjectDbContext _context;

        public SearchProductController(ProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string keyword)
        {
            var results = _context.Products
        .Where(p => p.Name != null && EF.Functions.Like(p.Name, "%" + keyword + "%"))
        .ToList();

            ViewData["Keyword"] = keyword;
            return View("Index", results);
        }
    }

  
}
