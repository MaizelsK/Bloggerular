using Bloggerular.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bloggerular.DataAccessLayer.EF
{
  public class BlogContext : DbContext
  {
    public DbSet<BlogPost> BlogPosts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Bloggerular;Trusted_Connection=True;");
    }
  }
}
