using System;
using AutoMapper;
using HaoBlogApi.Dtos;
using HaoBlogApi.Models;

namespace HaoBlogApi.Profiles
{
  public class HaoBlogApiProfile : Profile
  {
    public HaoBlogApiProfile()
    {

      // Source -> Target
      CreateMap<Role, RoleDto>();
      CreateMap<RoleDto, Role>();
    }
  }
}