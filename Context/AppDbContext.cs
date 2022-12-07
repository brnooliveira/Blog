using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Context;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=<Bbdt75220821>");
        optionsBuilder.LogTo(Console.WriteLine);
    }
}