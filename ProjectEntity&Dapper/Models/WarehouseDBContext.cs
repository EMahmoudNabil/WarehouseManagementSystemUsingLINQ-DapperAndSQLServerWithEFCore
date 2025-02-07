using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity_Dapper.Models
{
    public class WarehouseDBContext :DbContext
    {

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Customers> Customer { get; set; }
       
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Invoicess> Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=DESKTOP-8JFRNPP\\SQLEXPRESS;Database=Warehouse;Trusted_Connection=True; TrustServerCertificate=True;");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //index in email and phone
            modelBuilder.Entity<Customers>()
                .HasIndex(c => c.PhoneNumber)
                .IsUnique();

            modelBuilder.Entity<Customers>()
                .HasIndex(c => c.Email)
                .IsUnique();
 

            // إضافة التصنيفات
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Clothing" },
            new Category { Id = 3, Name = "Furniture" },
            new Category { Id = 4, Name = "Books" },
            new Category { Id = 5, Name = "Home Appliances" }
        );

            // إنشاء بيانات المنتجات
            var products = new List<Product>();

            for (int i = 1; i <= 100; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Code = $"P{i:000}",
                    Name = $"Product {i}",
                    Price = 10.0m + (i * 5), // مثال: سعر ثابت قابل للتنبؤ
                    Quantity = 100 - i,      // مثال: كمية ثابتة
                    Note = $"Description for product {i}",
                    catid = (i % 5) + 1 // توزيع منتظم على التصنيفات 1-5
                });
            }
            // إضافة بيانات العملاء
            modelBuilder.Entity<Customers>().HasData(
                new Customers { Id = 1, CustomerName = "John Doe", PhoneNumber = "1234567890", Email = "johndoe@example.com", Address = "123 Main St", City = "New York", Country = "USA", isActive = true, Notes = "Regular customer" },
                new Customers { Id = 2, CustomerName = "Jane Smith", PhoneNumber = "0987654321", Email = "janesmith@example.com", Address = "456 Elm St", City = "Los Angeles", Country = "USA", isActive = true, Notes = "VIP customer" },
                new Customers { Id = 3, CustomerName = "Ali Hassan", PhoneNumber = "01011223344", Email = "alihassan@example.com", Address = "15 Nile St", City = "Cairo", Country = "Egypt", isActive = false, Notes = "Inactive account" }
            );
            modelBuilder.Entity<Product>().HasData(products);
        }



    }
}
