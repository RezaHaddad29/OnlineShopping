namespace OnlineShop.Core.Entities
{
    public class PopularBrand
    {
        public int ID { get; set; }
        public int BrandID { get; set; }
        public DateTime CreatedAt { get; set; }

        
        public Brand Brand { get; set; }
    }
}
