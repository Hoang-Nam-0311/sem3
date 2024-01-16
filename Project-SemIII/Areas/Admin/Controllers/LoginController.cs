
using Microsoft.AspNetCore.Mvc;
using Project_Sem3.Models;

namespace Project_SemIII.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class LoginController : Controller
    {
        private readonly ProjectDbContext _context;

        public LoginController(ProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User model)
        {
            if (HttpContext.Request.Method == "POST")
            {
                try
                {
                    User user = _context.Users.Where(u => u.Username == model.Username && u.Password == model.Password).First();
                    if (user != null)
                    {
                        HttpContext.Session.SetInt32("logged", user.Id);
                        HttpContext.Session.SetString("username", user.Username);
                        return Redirect("/admin");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Loi");
                }
            }
            return View();
        }

    }    
}
