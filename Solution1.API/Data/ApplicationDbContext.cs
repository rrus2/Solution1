using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Solution1.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution1.API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>(options =>
            {
                options.HasKey(x => x.ProductID);
                options.Property(x => x.Name).IsRequired();
                options.Property(x => x.Price).IsRequired();
                options.Property(x => x.Stock).IsRequired();
                options.Property(x => x.GenreID).IsRequired();
            });

            builder.Entity<Genre>(options =>
            {
                options.HasKey(x => x.GenreID);
                options.Property(x => x.Name).IsRequired();
            });
        }
    }
}
