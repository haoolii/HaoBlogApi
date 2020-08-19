using System.Collections.Generic;
using HaoBlogApi.Models;

namespace HaoBlogApi.Repos
{
  public interface IUserRepo
  {
    IEnumerable<User> GetAllUsers();

    User GetUserById(int id);

    void CreateUser(User user);

    void UpdateUser(User user);

    void DeleteUser(User user);
    bool SaveChanges();
  }
}