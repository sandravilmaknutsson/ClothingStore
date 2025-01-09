using ClothingStore.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<CategoryRepositoryInterface, CategoryRepository>();
builder.Services.AddScoped<ProductRepositoryInterface, ProductRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
