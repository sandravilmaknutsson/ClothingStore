namespace ClothingStore.Model
{
  public class ProductRepository : ProductRepositoryInterface //Dummy data, will be exchanged for db in future
  {
    private readonly CategoryRepositoryInterface _CategoryRepository = new CategoryRepository();
    public IEnumerable<Product> AllProducts => new List<Product> {
        new Product{ProductId=1,Name="T-Shirt", Brand="Zara", CategoryId=1, Category=_CategoryRepository.AllCategories.ToList()[0], ImageUrl="test.jpg", Colors=["pink", "white", "blue"], Description="A simple T-shirt in beautiful colors.", Information="Material: 100% wool", IsInStock=true, Price=199, Rating="5/10", Sizes=["S", "M"] },
          new Product{ProductId=2,Name="'Jeans'", Brand="H&M", CategoryId=2, Category=_CategoryRepository.AllCategories.ToList()[1], ImageUrl="test.jpg", Colors=["Green", "white", "blue"], Description="Beautiful jeans in a variaty of colors.", Information="Material: 100% cotton", IsInStock=false, Price=599, Rating="8/10", Sizes=[] },
            new Product{ProductId=3,Name="Leather Jacket", Brand="Zara", CategoryId=3, Category=_CategoryRepository.AllCategories.ToList()[2], ImageUrl="test.jpg", Colors=["Black", "Brown",], Description="A cool leather jacket perfect for summer.", Information="Material: 100% leather", IsInStock=true, Price=349, Rating="6/10", Sizes=["S", "M", "L"] }
     };

    public Product? GetProductById(int productId) => AllProducts.FirstOrDefault(p => p.ProductId == productId);
  }
}