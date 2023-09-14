using Microsoft.EntityFrameworkCore;
using Product.Models;

namespace Product.Data
{
    public class CategoryContext : DbContext
    {
        public CategoryContext(DbContextOptions<CategoryContext> options) : base(options) 
        { 
        
        }
        public DbSet<Category> Categories { get; set; }     
    }
}
