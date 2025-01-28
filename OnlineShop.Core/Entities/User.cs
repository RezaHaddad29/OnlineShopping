namespace OnlineShop.Core.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
