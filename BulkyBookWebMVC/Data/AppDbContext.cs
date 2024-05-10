using BulkyBookWebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWebMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { }
        public DbSet<Category> Categorys { get; set; }
    }
    
}
