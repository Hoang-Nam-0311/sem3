using Microsoft.AspNetCore.Mvc;
using Project_Sem3.Models;

namespace Project_SemIII.Controllers
{
    public class QuoteController : Controller
    {
        private readonly ProjectDbContext _context;

        public QuoteController(ProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(QuoteUs model)
        {

            if (ModelState.IsValid)
            {

                _context.QuoteUs.Add(model);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Feedback sent successfully";

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
