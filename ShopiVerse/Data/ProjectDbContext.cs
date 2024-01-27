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
        }
}
}

