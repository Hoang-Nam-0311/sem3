using Microsoft.AspNetCore.Mvc;
using Project_Sem3.Models;

namespace Project_SemIII.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        ProjectDbContext db = new ProjectDbContext();
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
