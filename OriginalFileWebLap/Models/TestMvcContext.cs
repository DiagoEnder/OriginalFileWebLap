using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OriginalFileWebLap.Models;

public partial class TestMvcContext : DbContext
{
    public TestMvcContext()
    {
    }

    public TestMvcContext(DbContextOptions<TestMvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MayTinh> MayTinhs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-FAANHK7K\\SQLEXPRESS;Initial Catalog=TestMVC;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MayTinh>(entity =>
        {
            entity.HasKey(e => e.IdmayTinh).HasName("PK__MayTinh__C9B084F7971570BE");

            entity.ToTable("MayTinh");

            entity.Property(e => e.IdmayTinh)
                .HasMaxLength(100)
                .HasColumnName("IDMayTinh");
            entity.Property(e => e.NgayBaoHanh).HasColumnType("date");
            entity.Property(e => e.NgaySanXuat).HasColumnType("date");
            entity.Property(e => e.TenMayTinh).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
