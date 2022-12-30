using CCTVHomePage.Models;
using CCTVHomePage.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CCTVHomePage.Controllers
{
    public class HomeController : Controller
    {

        AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel()
            {
                Services = _context.Services.ToList(),
                Members= _context.Members.ToList(),
                Sliders= _context.Sliders.ToList(),
                Prices= _context.Prices.ToList(),
                Comments= _context.Comments.ToList()
            };
            return View(home);
        }

    }
}