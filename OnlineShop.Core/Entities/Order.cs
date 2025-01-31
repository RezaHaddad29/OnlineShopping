namespace OnlineShop.Core.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int StatusID { get; set; }
        public int AddressID { get; set; }
        public bool IsFinalized { get; set; }
        public int PaymentStatusID { get; set; }
        public int ShippingStatusID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        
        public User User { get; set; }
        public OrderStatus Status { get; set; }
        public Address Address { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public ShippingStatus ShippingStatus { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
