using Microsoft.AspNetCore.Identity;
using Petstore_GroupProject8.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<PetStoreDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<Customer, IdentityRole>()
    .AddEntityFrameworkStores<PetStoreDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddSingleton<IEmailSender, EmailSender>();

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();
app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();


app.MapRazorPages();


app.MapControllerRoute(
    name: "add_to_cart",
    pattern: "products/addtocart",
    defaults: new { controller = "Products", action = "AddToCart" });

app.MapControllerRoute(
    name: "get_cart",
    pattern: "products/getcart",
    defaults: new { controller = "Products", action = "GetCart" });

app.MapControllerRoute(
    name: "products_category_search_sort",
    pattern: "products/{category?}/search/{search?}/sort/{sortOrder?}",
    defaults: new { controller = "Products", action = "ProductsCatalog" });

app.MapControllerRoute(
    name: "products_category_search",
    pattern: "products/{category?}/search/{search?}",
    defaults: new { controller = "Products", action = "ProductsCatalog" });

app.MapControllerRoute(
    name: "products_category",
    pattern: "products/{category?}",
    defaults: new { controller = "Products", action = "ProductsCatalog" });


app.MapControllerRoute(
    name: "product_details",
    pattern: "products/details/{id:int}",
    defaults: new { controller = "Products", action = "ProductDetails" });



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
