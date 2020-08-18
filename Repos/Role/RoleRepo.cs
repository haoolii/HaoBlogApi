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

    public void DeleteRole(Role role)
    {
      if (role == null)
      {
        throw new ArgumentNullException(nameof(role));
      }
      _context.Roles.Remove(role);
    }

    public IEnumerable<Role> GetAllRoles()
    {
      return _context.Roles.ToList();
    }

    public Role GetRoleById(int id)
    {
      return _context.Roles.FirstOrDefault(r => r.Id == id);
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }

    public void UpdateRole(Role role)
    {
      // throw new NotImplementedException();
    }
  }
}