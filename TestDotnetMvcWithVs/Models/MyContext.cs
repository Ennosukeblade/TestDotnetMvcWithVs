using Microsoft.EntityFrameworkCore;

namespace TestDotnetMvcWithVs.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
            public DbSet<Movie> Movies { get; set; }
            public DbSet<Category> Categories { get; set; }
        
    }
}
