using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StudentProfile.EF.Tables;

namespace StudentProfile.EF;

public partial class StudentProfileContext : DbContext
{
    public StudentProfileContext()
    {
    }

    public StudentProfileContext(DbContextOptions<StudentProfileContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Detail> Details { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DbConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Detail>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
