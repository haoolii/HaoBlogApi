using System;
using System.Collections.Generic;
using System.Linq;
using HaoBlogApi.Data;
using HaoBlogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HaoBlogApi.Repos
{
  public class UserRepo : IUserRepo
  {
    private readonly HaoBlogApiContext _context;

    public UserRepo(HaoBlogApiContext context)
    {
      _context = context;
    }
    public void CreateUser(User user)
    {
      if (user == null)
      {
        throw new ArgumentNullException(nameof(user));
      }
      _context.Users.Add(user);
    }

    public void DeleteUser(User user)
    {
      if (user == null)
      {
        throw new ArgumentNullException(nameof(user));
      }
      _context.Users.Remove(user);
    }

    public IEnumerable<User> GetAllUsers()
    {
      return _context.Users.Include(user => user.Role).ToList();
    }

    public User GetUserById(int id)
    {
      return _context.Users.Include(user => user.Role)
                      .FirstOrDefault(u => u.Id == id);
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }

    public void UpdateUser(User user)
    {
      throw new System.NotImplementedException();
    }

  }
}