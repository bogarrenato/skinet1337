using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.data
{
    //DbContext is an abstractions for our database - not need to write a single line of SQL
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}