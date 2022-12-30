using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        [StringLength(maximumLength: 30)]
        public string Title { get; set; }

        [StringLength(maximumLength: 1500)]
        public string Decscription { get; set; }

        [StringLength(maximumLength: 50)]
        public string Client { get; set; }
        public DateTime Date { get; set; }
        public string ProjectUrl { get; set; }
        public Category Category { get; set; }
        public List<PortfolioImage> PImages { get; set; }


    }
}
