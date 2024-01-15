using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AEHKLMNSTZDotNetCore.DbFirstCommandApp.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblBlog> TblBlogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=TestDb;User ID=sa;Password=sa@123;Trusted_Connection=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblBlog>(entity =>
        {
            entity.HasKey(e => e.BlogId);

            entity.ToTable("Tbl_Blog");

            entity.Property(e => e.BlogId).HasColumnName("Blog_Id");
            entity.Property(e => e.BlogAuthor)
                .HasMaxLength(50)
                .HasColumnName("Blog_Author");
            entity.Property(e => e.BlogContent)
                .HasMaxLength(50)
                .HasColumnName("Blog_Content");
            entity.Property(e => e.BlogTitle)
                .HasMaxLength(50)
                .HasColumnName("Blog_Title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
