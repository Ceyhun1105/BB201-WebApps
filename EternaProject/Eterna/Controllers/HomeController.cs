using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Sliders=_dbContext.Sliders.ToList(),
                Services= _dbContext.Services.ToList(),
                Clients= _dbContext.Clients.ToList()
            };

            return View(homeViewModel);
        }

       

       
    }
}