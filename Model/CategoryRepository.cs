namespace ClothingStore.Model
{
    public class CategoryRepository : CategoryRepositoryInterface //Dummy data, will be exchanged for db in future
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{ CategoryId=1, Name="Shirts", Description="Shirts are mostly tight and thin in their fabric."},
            new Category{CategoryId=2, Name="Pants", Description="Bottoms and pants in different fabrics"},
            new Category{CategoryId=3, Name="Jackets", Description="Warmer pullovers and jackets for colder weather."}
        };
    }
}