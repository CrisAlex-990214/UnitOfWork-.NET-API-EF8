using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence
{
    public class Context : DbContext
    {
        public Context(DbContextOptions opts) : base(opts)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
