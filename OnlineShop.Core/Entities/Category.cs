namespace OnlineShop.Core.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public int? ParentID { get; set; }
        public string Title { get; set; }

        
        public Category ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
