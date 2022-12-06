using Blog.Context;
using Blog.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
            context.Tags.Add(tag);
            context.SaveChanges();
        }
    }
}