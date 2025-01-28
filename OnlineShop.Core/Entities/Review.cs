namespace OnlineShop.Core.Entities
{
    public class Review
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
