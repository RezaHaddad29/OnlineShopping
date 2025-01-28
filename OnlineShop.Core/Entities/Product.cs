namespace OnlineShop.Core.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Desc { get; set; }
        public string ImageURL { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<FlashSale> FlashSales { get; set; }
    }
}
