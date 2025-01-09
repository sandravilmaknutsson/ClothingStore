namespace ClothingStore.Model
{
    public interface CategoryRepositoryInterface
    {
        IEnumerable<Category> AllCategories { get; }
    }
}