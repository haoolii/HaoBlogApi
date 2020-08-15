using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HaoBlogApi.Models {
  public class Post {

    public Post () {
      PostTags = new HashSet<PostTag> ();
      this.CreatedDate = DateTime.UtcNow;
      this.UpdatedDate = DateTime.UtcNow;
    }

    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Body { get; set; }

    [Required]
    public User Author { get; set; }

    public ICollection<PostTag> PostTags { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}