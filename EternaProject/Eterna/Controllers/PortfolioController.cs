using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PortfolioViewModel portfolioViewModel= new PortfolioViewModel()
            {
                Portfolios=_context.Portfolios.Include(x=>x.Category).Include(x=>x.PImages).ToList(),
                Categories=_context.Categories.ToList(),
                Clients = _context.Clients.ToList()
                
            };
            return View(portfolioViewModel);
        }
        public IActionResult Detail(int id)
        {
            Portfolio portfolio = _context.Portfolios.Include(x => x.Category).Include(x => x.PImages).FirstOrDefault(x => x.Id == id);
            return View(portfolio);
        }
    }
}
