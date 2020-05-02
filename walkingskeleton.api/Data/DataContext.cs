using Microsoft.EntityFrameworkCore;
using walkingskeleton.api.Models;

namespace walkingskeleton.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
    }
}