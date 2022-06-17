using Microsoft.EntityFrameworkCore;
using ProductAPI.Domain.Models;

namespace ProductAPI.Infrastructure.Data {
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : 
            base(options)
        {
        }
        public DbSet<Product> Characters { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}