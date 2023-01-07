namespace SoapLush.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string Ingredients { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public double Price { get; set; }

        public int CategoryId { get; set; } //foreign key
        public Category? Category { get; set; } //Reference Navigation

        public int SubCategoryId { get; set; } //foreign key

        public SubCategory? SubCategory { get; set; } //Reference Navigation
    }
}
