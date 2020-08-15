using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HaoBlogApi.Models {
  public class Tag {
    public Tag () {
      PostTags = new HashSet<PostTag> ();
      this.CreatedDate = DateTime.UtcNow;
      this.UpdatedDate = DateTime.UtcNow;
    }

    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<PostTag> PostTags { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}