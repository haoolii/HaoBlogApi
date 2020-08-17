using System.Collections.Generic;
using HaoBlogApi.Models;

namespace HaoBlogApi.Repos
{
  public interface IRoleRepo
  {
    bool SaveChanges();

    IEnumerable<Role> GetAllRoles();

    void CreateRole(Role role);
  }
}