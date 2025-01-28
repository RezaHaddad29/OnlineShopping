namespace OnlineShop.Core.Entities
{
    public class Brand
    {
        public int ID { get; set; }
        public string Title { get; set; }

        
        public ICollection<Product> Products { get; set; }
        public ICollection<PopularBrand> PopularBrands { get; set; }
    }
}
