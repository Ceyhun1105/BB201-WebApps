using CCTV.Models;

namespace CCTV.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public List<Price> Prices { get; set; }
    }
}
