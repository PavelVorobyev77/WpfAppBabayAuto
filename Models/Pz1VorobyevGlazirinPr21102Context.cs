using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfAppBabayAuto.Models;

public partial class Pz1VorobyevGlazirinPr21102Context : DbContext
{
    public Pz1VorobyevGlazirinPr21102Context()
    {
    }

    public Pz1VorobyevGlazirinPr21102Context(DbContextOptions<Pz1VorobyevGlazirinPr21102Context> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UsersDetail> UsersDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-BK1T0PD\\SQLEXPRESS;Database=PZ1_Vorobyev_Glazirin_PR-21.102;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.Property(e => e.IdUser)
                .ValueGeneratedNever()
                .HasColumnName("idUser");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
        });

        modelBuilder.Entity<UsersDetail>(entity =>
        {
            entity.HasKey(e => e.IdDetail);

            entity.ToTable("UsersDetail");

            entity.Property(e => e.IdDetail)
                .ValueGeneratedNever()
                .HasColumnName("idDetail");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .HasColumnName("patronymic");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UsersDetails)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsersDetail_Users");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
