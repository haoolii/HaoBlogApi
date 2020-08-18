using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HaoBlogApi.Dtos;
using HaoBlogApi.Repos;
using AutoMapper;
using HaoBlogApi.Models;
using System;

namespace HaoBlogApi.Controllers
{

  [Route("api/[Controller]")]
  [ApiController]
  public class RolesController : ControllerBase
  {
    private readonly IRoleRepo _repository;
    private readonly IMapper _mapper;
    public RolesController(
      IRoleRepo repository,
      IMapper mapper
    )
    {
      _repository = repository;
      _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Role>> GetAllRoles()
    {
      var roles = _repository.GetAllRoles();
      return Ok(roles);
    }

    [HttpGet("{id}", Name = "GetRoleById")]
    public ActionResult<Role> GetRoleById(int id)
    {
      var roleModelFromRepo = _repository.GetRoleById(id);
      if (roleModelFromRepo == null)
      {
        return NotFound();
      }
      return Ok(roleModelFromRepo);
    }

    [HttpPost]
    public ActionResult<Role> CreateRole(RoleDto roleDto)
    {
      var roleModel = _mapper.Map<Role>(roleDto);
      _repository.CreateRole(roleModel);
      _repository.SaveChanges();
      return Ok(roleModel);
    }

    [HttpPut("{id}")]
    public ActionResult<Role> UpdateRole(int id, RoleDto roleDto)
    {
      var roleModelFromRepo = _repository.GetRoleById(id);
      if (roleModelFromRepo == null)
      {
        return NotFound();
      }
      _mapper.Map(roleDto, roleModelFromRepo);
      _repository.SaveChanges();
      return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteCommand(int id)
    {
      var roleModelFromRepo = _repository.GetRoleById(id);
      if (roleModelFromRepo == null)
      {
        return NotFound();
      }
      _repository.DeleteRole(roleModelFromRepo);
      _repository.SaveChanges();
      return NoContent();
    }
  }
}