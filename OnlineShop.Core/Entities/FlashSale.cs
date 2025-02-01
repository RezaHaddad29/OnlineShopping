namespace OnlineShop.Core.Entities
{
    public class FlashSale
    {
        public int ID { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
