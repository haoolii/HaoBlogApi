using System.Collections.Generic;
using HaoBlogApi.Models;

namespace HaoBlogApi.Repos
{
  public interface IPostRepo
  {
    bool SaveChanges();

    IEnumerable<Post> GetAllPosts();

    void CreatePost(Post post);

    void UpdatePost(Post post);

    void DeletePost(Post post);

  }
}
