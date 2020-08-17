using System;
using System.Collections.Generic;
using System.Linq;
using HaoBlogApi.Data;
using HaoBlogApi.Models;

namespace HaoBlogApi.Repos
{
  public class RoleRepo : IRoleRepo
  {
    private readonly HaoBlogApiContext _context;
    public RoleRepo(HaoBlogApiContext context)
    {
      _context = context;
    }

    public void CreateRole(Role role)
    {
      if (role == null)
      {
        throw new ArgumentNullException(nameof(role));
      }
      _context.Roles.Add(role);
    }

    public IEnumerable<Role> GetAllRoles()
    {
      return _context.Roles.ToList();
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }
  }
}