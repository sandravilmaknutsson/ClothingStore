namespace ClothingStore.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!; // Shirt, Pants etc.
        public string Name { get; set; } = string.Empty;
        public string? Brand { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsInStock { get; set; }
        public string? Rating { get; set; }
        public List<string>? Colors { get; set; }
        public List<string>? Sizes { get; set; }
        public string? Information { get; set; } // Fabrics etc.
    }
}