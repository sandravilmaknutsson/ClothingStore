namespace ClothingStore.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Price { get; set; }
        public string? Category { get; set; }
        public bool IsInStock { get; set; }
        public string? Sizes { get; set; }
    }
}