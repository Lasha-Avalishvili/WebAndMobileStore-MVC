namespace WebAndMobileStore.Models
{
    public class Item
    {
       public Item()
        {
            ImageUrls = new List<string>();  
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> ImageUrls { get; set; }
    }
}
