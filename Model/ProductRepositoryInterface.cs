namespace ClothingStore.Model
{
    public interface ProductRepositoryInterface
    {
        IEnumerable<Product> AllProducts { get; }
        Product? GetProductById(int productId);
    }
}