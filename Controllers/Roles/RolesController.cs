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
    public ActionResult<IEnumerable<RoleDto>> GetAllRoles()
    {
      var roles = _repository.GetAllRoles();
      return Ok(_mapper.Map<IEnumerable<RoleDto>>(roles));
    }

    [HttpPost]
    public ActionResult<RoleDto> CreateRole(RoleDto roleDto)
    {
      var roleModel = _mapper.Map<Role>(roleDto);
      _repository.CreateRole(roleModel);
      _repository.SaveChanges();
      var roleReplyDto = _mapper.Map<RoleDto>(roleModel);
      return Ok(roleReplyDto);
    }
  }
}