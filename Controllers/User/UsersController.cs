using System.Collections.Generic;
using AutoMapper;
using HaoBlogApi.Data;
using HaoBlogApi.Dtos;
using HaoBlogApi.Models;
using HaoBlogApi.Repos;
using Microsoft.AspNetCore.Mvc;

namespace HaoBlogApi.Controllers
{
  [Route("api/[Controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private readonly IUserRepo _repository;
    private readonly IRoleRepo _roleRepo;
    private readonly IMapper _mapper;
    public UsersController(
      IUserRepo repository,
      IRoleRepo roleRepo,
      IMapper mapper
    )
    {
      _repository = repository;
      _roleRepo = roleRepo;
      _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<User>> GetAllUsers()
    {
      var users = _repository.GetAllUsers();
      return Ok(users);
    }

    [HttpGet("{id}", Name = "GetUserById")]
    public ActionResult<User> GetUserById(int id)
    {
      var userModel = _repository.GetUserById(id);
      if (userModel == null)
      {
        return NotFound();
      }
      return Ok(userModel);
    }

    [HttpPost]
    public ActionResult<User> CreateUser(UserDto userDto)
    {
      var roleModel = _roleRepo.GetRoleById(userDto.RoleId);
      if (roleModel == null)
      {
        return NotFound();
      }
      var userModel = new User
      {
        Name = userDto.Name,
        Email = userDto.Email,
        Role = roleModel,
        Password = userDto.Password
      };
      _repository.CreateUser(userModel);
      _repository.SaveChanges();
      return Ok(userModel);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteUser(int id)
    {
      var userModel = _repository.GetUserById(id);
      if (userModel == null)
      {
        return NotFound();
      }
      _repository.DeleteUser(userModel);
      _repository.SaveChanges();
      return NoContent();
    }

    [HttpPut("{id}")]
    public ActionResult UpdateUser(int id, UserDto userDto)
    {
      var userModel = _repository.GetUserById(id);
      if (userModel == null)
      {
        return NotFound();
      }
      var roleModel = _roleRepo.GetRoleById(userDto.RoleId);
      if (roleModel == null)
      {
        return NotFound();
      }
      userModel.Role = roleModel;
      _mapper.Map(userDto, userModel);
      _repository.SaveChanges();
      return Ok(userModel);
    }

  }
}