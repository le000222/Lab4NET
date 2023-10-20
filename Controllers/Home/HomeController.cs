using Lab4NET.Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab4NET.Controllers.Home
{
    public class HomeController : Controller
    {
        private readonly SportsDbContext _context;

        public HomeController(SportsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
