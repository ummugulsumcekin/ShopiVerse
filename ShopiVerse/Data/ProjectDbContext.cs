using Microsoft.EntityFrameworkCore;
using ShopiVerse.Models;

namespace ShopiVerse.Data
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
    new Customer { Id = 1, Name = "Ali", Surname = "Yılmaz", City = "İstanbul", District = "Beşiktaş", Address = "Beşiktaş Mahallesi, No:1" },
    new Customer { Id = 2, Name = "Ayşe", Surname = "Kaya", City = "Ankara", District = "Çankaya", Address = "Çankaya Mahallesi, No:2" },
    new Customer { Id = 3, Name = "Mehmet", Surname = "Öz", City = "İzmir", District = "Bornova", Address = "Bornova Mahallesi, No:3" },
    new Customer { Id = 4, Name = "Elif", Surname = "Demir", City = "Bursa", District = "Nilüfer", Address = "Nilüfer Mahallesi, No:4" },
    new Customer { Id = 5, Name = "Ahmet", Surname = "Can", City = "Antalya", District = "Konyaaltı", Address = "Konyaaltı Mahallesi, No:5" },
    new Customer { Id = 6, Name = "Zeynep", Surname = "Balcı", City = "Samsun", District = "İlkadım", Address = "İlkadım Mahallesi, No:6" },
    new Customer { Id = 7, Name = "Kemal", Surname = "Yıldız", City = "Trabzon", District = "Ortahisar", Address = "Ortahisar Mahallesi, No:7" },
    new Customer { Id = 8, Name = "Seda", Surname = "Akar", City = "Eskişehir", District = "Tepebaşı", Address = "Tepebaşı Mahallesi, No:8" },
    new Customer { Id = 9, Name = "Murat", Surname = "Tekin", City = "Kocaeli", District = "İzmit", Address = "İzmit Mahallesi, No:9" },
    new Customer { Id = 10, Name = "Esra", Surname = "Kurt", City = "Gaziantep", District = "Şahinbey", Address = "Şahinbey Mahallesi, No:10" }
                );
            modelBuilder.Entity<Product>().HasData(
    new Product { Id = 1, Name = "Ürün 1", Price = 100.00m, StockQuantity = 50 },
    new Product { Id = 2, Name = "Ürün 2", Price = 150.00m, StockQuantity = 40 },
    new Product { Id = 3, Name = "Ürün 3", Price = 200.00m, StockQuantity = 30 },
    new Product { Id = 4, Name = "Ürün 4", Price = 250.00m, StockQuantity = 20 },
    new Product { Id = 5, Name = "Ürün 5", Price = 300.00m, StockQuantity = 10 },
    new Product { Id = 6, Name = "Ürün 6", Price = 350.00m, StockQuantity = 5 },
    new Product { Id = 7, Name = "Ürün 7", Price = 400.00m, StockQuantity = 15 },
    new Product { Id = 8, Name = "Ürün 8", Price = 450.00m, StockQuantity = 25 },
    new Product { Id = 9, Name = "Ürün 9", Price = 500.00m, StockQuantity = 35 },
    new Product { Id = 10, Name = "Ürün 10", Price = 550.00m, StockQuantity = 45 }
);
            modelBuilder.Entity<Order>().HasData(
    new Order { Id = 1, CustomerId = 1, OrderDate = new DateTime(2023, 1, 1), TotalAmount = 500.00m },
    new Order { Id = 2, CustomerId = 2, OrderDate = new DateTime(2023, 1, 2), TotalAmount = 400.00m },
    new Order { Id = 3, CustomerId = 3, OrderDate = new DateTime(2023, 1, 3), TotalAmount = 300.00m },
    new Order { Id = 4, CustomerId = 4, OrderDate = new DateTime(2023, 1, 4), TotalAmount = 200.00m },
    new Order { Id = 5, CustomerId = 5, OrderDate = new DateTime(2023, 1, 5), TotalAmount = 100.00m },
    new Order { Id = 6, CustomerId = 6, OrderDate = new DateTime(2023, 1, 6), TotalAmount = 600.00m },
    new Order { Id = 7, CustomerId = 7, OrderDate = new DateTime(2023, 1, 7), TotalAmount = 700.00m },
    new Order { Id = 8, CustomerId = 8, OrderDate = new DateTime(2023, 1, 8), TotalAmount = 800.00m },
    new Order { Id = 9, CustomerId = 9, OrderDate = new DateTime(2023, 1, 9), TotalAmount = 900.00m },
    new Order { Id = 10, CustomerId = 10, OrderDate = new DateTime(2023, 1, 10), TotalAmount = 1000.00m }
);
            modelBuilder.Entity<OrderDetail>().HasData(
    new OrderDetail { Id = 1, OrderId = 1, ProductId = 1, Quantity = 2, UnitPrice = 100.00m },
    new OrderDetail { Id = 2, OrderId = 1, ProductId = 2, Quantity = 1, UnitPrice = 150.00m },
    new OrderDetail { Id = 3, OrderId = 2, ProductId = 3, Quantity = 3, UnitPrice = 200.00m },
    new OrderDetail { Id = 4, OrderId = 2, ProductId = 4, Quantity = 2, UnitPrice = 250.00m },
    new OrderDetail { Id = 5, OrderId = 3, ProductId = 5, Quantity = 1, UnitPrice = 300.00m },
    new OrderDetail { Id = 6, OrderId = 3, ProductId = 6, Quantity = 2, UnitPrice = 350.00m },
    new OrderDetail { Id = 7, OrderId = 4, ProductId = 7, Quantity = 1, UnitPrice = 400.00m },
    new OrderDetail { Id = 8, OrderId = 4, ProductId = 8, Quantity = 1, UnitPrice = 450.00m },
    new OrderDetail { Id = 9, OrderId = 5, ProductId = 9, Quantity = 3, UnitPrice = 500.00m },
    new OrderDetail { Id = 10, OrderId = 5, ProductId = 10, Quantity = 2, UnitPrice = 550.00m }
);
            modelBuilder.Entity<Cart>().HasData(
    new Cart { Id = 1, CustomerId = 1, ProductId = 1, Quantity = 2, Price = 100.00m },
    new Cart { Id = 2, CustomerId = 1, ProductId = 2, Quantity = 3, Price = 150.00m },
    new Cart { Id = 3, CustomerId = 2, ProductId = 3, Quantity = 1, Price = 200.00m },
    new Cart { Id = 4, CustomerId = 2, ProductId = 4, Quantity = 2, Price = 250.00m },
    new Cart { Id = 5, CustomerId = 3, ProductId = 5, Quantity = 1, Price = 300.00m },
    new Cart { Id = 6, CustomerId = 3, ProductId = 6, Quantity = 1, Price = 350.00m },
    new Cart { Id = 7, CustomerId = 4, ProductId = 7, Quantity = 1, Price = 400.00m },
    new Cart { Id = 8, CustomerId = 4, ProductId = 8, Quantity = 1, Price = 450.00m },
    new Cart { Id = 9, CustomerId = 5, ProductId = 9, Quantity = 2, Price = 500.00m },
    new Cart { Id = 10, CustomerId = 5, ProductId = 10, Quantity = 3, Price = 550.00m }
);



        }
    }
}

