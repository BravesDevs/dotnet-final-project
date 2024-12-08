//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Petstore_GroupProject8.Models;
//using System.Linq;

//namespace Petstore_GroupProject8.Controllers
//{
//    public class ProductsController : Controller
//    {
//        private readonly PetStoreDbContext _context;

//        public ProductsController(PetStoreDbContext context)
//        {
//            _context = context;
//        }

//        // Acción para mostrar el catálogo de productos
//        public IActionResult ProductsCatalog(string search, string category, string sortOrder)
//        {
//            IQueryable<Product> products = _context.Products.Include(p => p.Category);

//            // Filtrar por búsqueda
//            if (!string.IsNullOrEmpty(search))
//            {
//                products = products.Where(p => p.Name.Contains(search));
//            }

//            // Filtrar por categoría
//            if (!string.IsNullOrEmpty(category) && category.ToLower() != "all")
//            {
//                products = products.Where(p => p.Category.CategoryName == category);
//                ViewBag.SelectedCategory = category;
//            }
//            else
//            {
//                ViewBag.SelectedCategory = "All";
//            }

//            // Ordenar productos
//            products = sortOrder switch
//            {
//                "price_asc" => products.OrderBy(p => p.Price),
//                "price_desc" => products.OrderByDescending(p => p.Price),
//                _ => products.OrderBy(p => p.Name),
//            };

//            // Pasar las categorías disponibles a la vista
//            ViewBag.Categories = _context.Categories.Select(c => c.CategoryName).Distinct().ToList();

//            return View(products.ToList());
//        }

//        // Acción para mostrar el detalle de un producto específico
//        public IActionResult ProductDetails(int id)
//        {
//            var product = _context.Products
//                .Include(p => p.Category)
//                .FirstOrDefault(p => p.ProductId == id);

//            if (product == null)
//            {
//                return NotFound();
//            }

//            return View(product);
//        }
//    }
//}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

            // Obtener el producto por el id
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                return NotFound();
            }

            // Obtener el carrito de la sesión
            var cart = HttpContext.Session.GetObject<List<OrderItem>>("Cart") ?? new List<OrderItem>();

            // Verificar si el producto ya está en el carrito
            var existingItem = cart.FirstOrDefault(item => item.ProductId == productId);

            if (existingItem != null)
            {
                // Si el producto ya está en el carrito, actualizar la cantidad y el precio total
                existingItem.Quantity += quantity;
                existingItem.TotalPrice = existingItem.Quantity * existingItem.PricePerUnit;
            }
            else
            {
                // Si no, agregar un nuevo item al carrito
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

            // Guardar el carrito actualizado en la sesión
            HttpContext.Session.SetObject("Cart", cart);

            // Redireccionar al catálogo de productos o a otra página adecuada
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

