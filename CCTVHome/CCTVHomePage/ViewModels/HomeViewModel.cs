using CCTVHomePage.Models;

namespace CCTVHomePage.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Member> Members { get; set; }
        public List<Price> Prices { get; set; }
        public List<Service> Services { get; set; }

    }
}
