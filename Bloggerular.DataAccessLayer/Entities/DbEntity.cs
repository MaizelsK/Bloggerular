using System;

namespace Bloggerular.DataAccessLayer.Entities
{
  public abstract class DbEntity
  {
    public long Id { get; set; }

    public DateTime DateCreated { get; set; }
    public DateTime DateLastModified { get; set; }
  }
}
