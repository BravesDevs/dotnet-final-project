using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Petstore_GroupProject8.Models
{
    public class PetStoreDbContext : IdentityDbContext<Customer>
    {
        public PetStoreDbContext(DbContextOptions<PetStoreDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Dry Dog Food", Description = "Premium dry dog food for all breeds", Price = 29.99M, StockQuantity = "100", ImageUrl = "dry_dog_food.jpg", CategoryId = 1 },
                new Product { ProductId = 2, Name = "Cat Toy Mouse", Description = "Fun mouse toy for cats", Price = 4.99M, StockQuantity = "200", ImageUrl = "cat_toy_mouse.jpg", CategoryId = 2 },
                new Product { ProductId = 3, Name = "Dog Leash", Description = "Durable leash for dogs", Price = 14.99M, StockQuantity = "150", ImageUrl = "dog_leash.jpg", CategoryId = 3 },
                new Product { ProductId = 4, Name = "Pet Shampoo", Description = "Gentle pet shampoo for grooming", Price = 9.99M, StockQuantity = "120", ImageUrl = "pet_shampoo.jpg", CategoryId = 4 },
                new Product { ProductId = 5, Name = "Dog Bed", Description = "Comfortable bed for dogs", Price = 39.99M, StockQuantity = "80", ImageUrl = "dog_bed.jpg", CategoryId = 6 },
                new Product { ProductId = 6, Name = "Cat Scratching Post", Description = "Scratching post to keep cats entertained", Price = 24.99M, StockQuantity = "60", ImageUrl = "cat_scratching_post.jpg", CategoryId = 2 },
                new Product { ProductId = 7, Name = "Pet First Aid Kit", Description = "First aid kit for pets", Price = 19.99M, StockQuantity = "50", ImageUrl = "pet_first_aid_kit.jpg", CategoryId = 5 },
                new Product { ProductId = 8, Name = "Training Pads", Description = "Training pads for puppies", Price = 15.99M, StockQuantity = "90", ImageUrl = "training_pads.jpg", CategoryId = 7 },
                new Product { ProductId = 9, Name = "Cat Collar", Description = "Adjustable collar for cats", Price = 7.99M, StockQuantity = "140", ImageUrl = "cat_collar.jpg", CategoryId = 3 },
                new Product { ProductId = 10, Name = "Dog Sweater", Description = "Warm sweater for small dogs", Price = 12.99M, StockQuantity = "70", ImageUrl = "dog_sweater.jpg", CategoryId = 8 },
                new Product { ProductId = 11, Name = "Bird Food Mix", Description = "Nutritious mix for pet birds", Price = 8.99M, StockQuantity = "110", ImageUrl = "bird_food_mix.jpg", CategoryId = 1 },
                new Product { ProductId = 12, Name = "Pet Nail Clippers", Description = "Nail clippers for grooming pets", Price = 6.99M, StockQuantity = "100", ImageUrl = "pet_nail_clippers.jpg", CategoryId = 4 },
                new Product { ProductId = 13, Name = "Dog Training Whistle", Description = "Whistle for dog training", Price = 5.99M, StockQuantity = "130", ImageUrl = "dog_training_whistle.jpg", CategoryId = 7 },
                new Product { ProductId = 14, Name = "Fish Tank Decorations", Description = "Decorations for fish tanks", Price = 11.99M, StockQuantity = "85", ImageUrl = "fish_tank_decorations.jpg", CategoryId = 3 },
                new Product { ProductId = 15, Name = "Cat Bed", Description = "Soft bed for cats", Price = 25.99M, StockQuantity = "75", ImageUrl = "cat_bed.jpg", CategoryId = 6 },
                new Product { ProductId = 16, Name = "Pet Vitamins", Description = "Vitamins for pets to maintain health", Price = 13.99M, StockQuantity = "95", ImageUrl = "pet_vitamins.jpg", CategoryId = 5 },
                new Product { ProductId = 17, Name = "Dog Harness", Description = "Comfortable harness for dogs", Price = 18.99M, StockQuantity = "60", ImageUrl = "dog_harness.jpg", CategoryId = 3 },
                new Product { ProductId = 18, Name = "Cat Grooming Brush", Description = "Brush for grooming cats", Price = 9.49M, StockQuantity = "125", ImageUrl = "cat_grooming_brush.jpg", CategoryId = 4 },
                new Product { ProductId = 19, Name = "Hamster Wheel", Description = "Exercise wheel for hamsters", Price = 14.49M, StockQuantity = "50", ImageUrl = "hamster_wheel.jpg", CategoryId = 2 },
                new Product { ProductId = 20, Name = "Dog Raincoat", Description = "Raincoat for dogs", Price = 16.99M, StockQuantity = "45", ImageUrl = "dog_raincoat.jpg", CategoryId = 8 }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Food", Description = "Pet food and treats" },
                new Category { CategoryId = 2, CategoryName = "Toys", Description = "Toys for pets" },
                new Category { CategoryId = 3, CategoryName = "Accessories", Description = "Pet accessories such as leashes, collars, etc." },
                new Category { CategoryId = 4, CategoryName = "Grooming", Description = "Grooming supplies for pets" },
                new Category { CategoryId = 5, CategoryName = "Healthcare", Description = "Healthcare products for pets" },
                new Category { CategoryId = 6, CategoryName = "Beds & Furniture", Description = "Pet beds and furniture" },
                new Category { CategoryId = 7, CategoryName = "Training", Description = "Training supplies for pets" },
                new Category { CategoryId = 8, CategoryName = "Clothing", Description = "Clothing for pets" }
            );
        }
    }
}

