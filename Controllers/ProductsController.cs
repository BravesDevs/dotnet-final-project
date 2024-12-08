using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petstore_GroupProject8.Models;
using System.Linq;

namespace Petstore_GroupProject8.Controllers
{
    public class ProductsController : Controller
    {
        private readonly PetStoreDbContext _context;

        public ProductsController(PetStoreDbContext context)
        {
            _context = context;
        }

        // Redirect to the ProductsCatalog action
        public IActionResult Index()
        {
            return RedirectToAction("ProductsCatalog");
        }

        // Acción para mostrar el catálogo de productos
        public IActionResult ProductsCatalog(string category, string search, string sortOrder)
        {
            IQueryable<Product> products = _context.Products.Include(p => p.Category);

            // Filtrar por categoría
            if (!string.IsNullOrEmpty(category) && category.ToLower() != "all")
            {
                products = products.Where(p => p.Category.CategoryName == category);
                ViewBag.SelectedCategory = category;
            }
            else
            {
                ViewBag.SelectedCategory = "All";
            }

            // Filtrar por búsqueda
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name.Contains(search));
                ViewBag.SearchQuery = search;
            }

            // Ordenar productos
            products = sortOrder switch
            {
                "price_asc" => products.OrderBy(p => p.Price),
                "price_desc" => products.OrderByDescending(p => p.Price),
                _ => products.OrderBy(p => p.Name),
            };

            // Pasar las categorías disponibles a la vista
            ViewBag.Categories = _context.Categories.Select(c => c.CategoryName).Distinct().ToList();

            return View(products.ToList());
        }

        // Acción para mostrar el detalle de un producto específico
        public IActionResult ProductDetails(int id)
        {
            var product = _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int quantity)
        {
            if (!User.Identity.IsAuthenticated)
            {
                // Redirige al login, y después del login vuelve al detalle del producto
                return Redirect("/Identity/Account/Login");
            }

            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                return NotFound();
            }

            var cart = HttpContext.Session.GetObject<List<OrderItem>>("Cart") ?? new List<OrderItem>();

            var existingItem = cart.FirstOrDefault(item => item.ProductId == productId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                existingItem.TotalPrice = existingItem.Quantity * existingItem.PricePerUnit;
            }
            else
            {
                var newItem = new OrderItem
                {
                    ProductId = product.ProductId,
                    Product = product,
                    Quantity = quantity,
                    PricePerUnit = product.Price,
                    TotalPrice = product.Price * quantity
                };

                cart.Add(newItem);
            }

            HttpContext.Session.SetObject("Cart", cart);

            return RedirectToAction("GetCart", "Products");
        }

        [HttpGet]
        public IActionResult GetCart()
        {
            var cart = HttpContext.Session.GetObject<List<OrderItem>>("Cart") ?? new List<OrderItem>();
            return View(cart);
        }
    }
}
