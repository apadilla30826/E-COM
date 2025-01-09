using E_COMWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace E_COMWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
