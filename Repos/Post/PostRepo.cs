using System.Collections.Generic;
using System.Linq;
using HaoBlogApi.Data;
using HaoBlogApi.Models;

namespace HaoBlogApi.Repos
{
  public class PostRepo : IPostRepo
  {
    private readonly HaoBlogApiContext _context;

    public PostRepo(HaoBlogApiContext context)
    {
      _context = context;
    }
    public void CreatePost(Post post)
    {
      throw new System.NotImplementedException();
    }

    public void DeletePost(Post post)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Post> GetAllPosts()
    {
      return _context.Posts.ToList();
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void UpdatePost(Post post)
    {
      throw new System.NotImplementedException();
    }
  }
}