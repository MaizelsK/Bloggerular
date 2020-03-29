namespace Bloggerular.DataAccessLayer.Entities
{
  public class BlogPost : DbEntity
  {
    public string Heading { get; set; }
    public string Content { get; set; }
  }
}
