using Microsoft.EntityFrameworkCore;
using SalesOrder.Api.Entities;

namespace SalesOrder.Api.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

        public DbSet<Media> Medias { get; set; }

        public DbSet<Photo> Photos { get; set; }
    }
}
