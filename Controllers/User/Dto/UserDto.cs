using System.ComponentModel.DataAnnotations;

namespace HaoBlogApi.Dtos
{
  public class UserDto
  {

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public int RoleId { get; set; }

    [Required]
    public string Password { get; set; }
  }
}