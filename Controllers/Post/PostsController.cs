using System.Collections.Generic;
using AutoMapper;
using HaoBlogApi.Models;
using HaoBlogApi.Repos;
using Microsoft.AspNetCore.Mvc;

namespace HaoBlogApi.Controllers
{

  [Route("api/[Controller]")]
  [ApiController]
  public class PostsController : ControllerBase
  {

    private readonly IPostRepo _repository;
    private readonly IMapper _mapper;

    public PostsController(
      IPostRepo repository,
      IMapper mapper
    )
    {
      _repository = repository;
      _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Post>> GetAllPosts()
    {
      var posts = _repository.GetAllPosts();
      return Ok(posts);
    }

    [HttpPost]
    public ActionResult<Post> CreatePost(Post post)
    {

      return null;
    }
  }
}