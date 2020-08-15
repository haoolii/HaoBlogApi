using System;
using System.ComponentModel.DataAnnotations;

namespace HaoBlogApi.Models {
  public class Role {
    public Role () {
      this.CreatedDate = DateTime.UtcNow;
      this.UpdatedDate = DateTime.UtcNow;
    }

    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

  }
}