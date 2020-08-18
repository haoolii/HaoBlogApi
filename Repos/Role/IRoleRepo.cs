using System.Collections.Generic;
using HaoBlogApi.Models;

namespace HaoBlogApi.Repos
{
  public interface IRoleRepo
  {
    bool SaveChanges();

    IEnumerable<Role> GetAllRoles();

    Role GetRoleById(int id);

    void CreateRole(Role role);

    void UpdateRole(Role role);

    void DeleteRole(Role role);
  }
}