using Blog.Context;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using var context = new AppDbContext();

        // var user = new User
        // {
        //     Name = "Breno Oliviera",
        //     Slug = "brenooliveira",
        //     Email = "breno@example.com",
        //     Bio = "Estudante Dotnet",
        //     Image = "site",
        //     PasswordHash = "12345678"
        // };

        // var category = new Category
        // {
        //     Name = "Backend",
        //     Slug = "backend"
        // };

        // var post = new Post
        // {
        //     Author = user,
        //     Category = category,
        //     Body = "<p>Hello World</p>",
        //     Slug = "comecandocomefcore",
        //     Summary = "Aprendendo Entity Framework Core",
        //     Title = "Comecando com EF Core",
        //     CreateDate = DateTime.Now,
        //     LastUpdateDate = DateTime.Now
        // };

        // context.Posts.Add(post);
        // context.SaveChanges();

        // var posts = context.Posts.AsNoTracking().Include(x => x.Author).Include(x => x.Category).OrderByDescending(x => x.LastUpdateDate).ToList();

        // foreach (var post in posts)
        //     Console.WriteLine($"{post.Title} escrito por {post.Author.Name} em {post.Category.Name}");

        var post = context.Posts.Include(x => x.Author).Include(x => x.Category).OrderByDescending(x => x.LastUpdateDate).FirstOrDefault();

        post.Author.Name = "Teste";

        context.Posts.Update(post);
        context.SaveChanges();


    }
}