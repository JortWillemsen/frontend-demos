using BlazorMud.API.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlazorMud.API.Adapters.Database.Postgres;

public class DatabaseContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
}