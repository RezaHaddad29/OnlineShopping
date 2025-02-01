namespace OnlineShop.Core.Entities
{
    public class Address
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string City { get; set; }
        public string AddressText { get; set; }
        public string PostalCode { get; set; }

        
        public User User { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
