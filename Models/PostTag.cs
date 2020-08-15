using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HaoBlogApi.Models {
  public class PostTag {
    public PostTag () {
      this.CreatedDate = DateTime.UtcNow;
      this.UpdatedDate = DateTime.UtcNow;
    }

    public int PostId { get; set; }

    public int TagId { get; set; }

    public Post Post { get; set; }

    public Tag Tag { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}