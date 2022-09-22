namespace WebApp.Models
{
    public class Stock
    {
        public int Symbol { get; set; }
        public string? Name { get; set; }
        public decimal OpenPrice { get; set; }
        public decimal ClosePrice { get; set; }

    }
}
