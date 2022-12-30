using Eterna.Models;

namespace Eterna.ViewModels
{
    public class PortfolioViewModel
    {
        public List<Portfolio> Portfolios { get; set; }
        public List<PortfolioImage> PortfolioImages { get; set; }
        public List<Category> Categories { get; set; }
        public List<Client> Clients { get; set; }

    }
}
