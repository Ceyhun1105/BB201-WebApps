namespace CCTVHomePage.Models
{
    public class Price
    {
        public int Id { get; set; }
        public string Plan { get; set; }
        public decimal PlanPrice { get; set; }
        public string TimeRange { get; set; }
        public string  Features { get; set; }
        public string OrderUrl { get; set; }
    }
}
