using Microsoft.EntityFrameworkCore;
using Tracingwebapi.Models;

namespace Tracingwebapi.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options) : base(options){ }

        public DbSet<Issue> Issues { get; set; }
    }
}
