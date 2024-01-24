using Microsoft.AspNetCore.Mvc;
using Project_Sem3.Models;

namespace Project_SemIII.Controllers
{
    public class ContactUsController : Controller
    {

        private readonly ProjectDbContext _context;

        public ContactUsController(ProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        { 
            return View(); 
           
        }
        [HttpPost]
        public IActionResult Index(ContactUs model)
        {
            if (ModelState.IsValid)
            {
                
                _context.ContactUs.Add(model);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Contact sent successfully";
               
                return RedirectToAction("Index");
            }

            return View(model);
        }

        
    }



}
