﻿namespace OnlineShop.Core.Entities
{
    public class PaymentStatus
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }

        
        public ICollection<Order> Orders { get; set; }
    }
}
