namespace OnlineShop.Core.Entities
{
    public class Slider
    {
        public int ID { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
