using HaoBlogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HaoBlogApi.Data {
  public class HaoBlogApiContext : DbContext {
    public HaoBlogApiContext (DbContextOptions<HaoBlogApiContext> options) : base (options) {

    }

    protected override void OnModelCreating (ModelBuilder modelBuilder) {
      modelBuilder.Entity<PostTag> ()
        .HasKey (pt => new { pt.PostId, pt.TagId });
      modelBuilder.Entity<PostTag> ()
        .HasOne (pt => pt.Post)
        .WithMany (p => p.PostTags)
        .HasForeignKey (pt => pt.PostId);
      modelBuilder.Entity<PostTag> ()
        .HasOne (pt => pt.Tag)
        .WithMany (t => t.PostTags)
        .HasForeignKey (pt => pt.TagId);

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
  }
}