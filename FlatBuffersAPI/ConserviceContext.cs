using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FlatBuffersAPI;

public partial class ConserviceContext : DbContext
{
    public ConserviceContext()
    {
    }

    public ConserviceContext(DbContextOptions<ConserviceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ProjectAssignment> ProjectAssignments { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }
    
    public virtual DbSet<DataTypeTest> DataTypeTests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Initial Catalog=Conservice;Data Source=localhost;User ID=sa;Password=yourStrong(!)Password;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProjectAssignment>(entity =>
        {
            entity.HasKey(e => e.AssignmentId).HasName("PK__ProjectA__32499E573D7CCBEE");

            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.Project).HasMaxLength(100);
            entity.Property(e => e.Role).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.ProjectAssignments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_ProjectAssignments_Users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__RandomDa__3214EC2795DB9BCD");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FavoriteColor).HasMaxLength(50);
            entity.Property(e => e.Hobbies).HasMaxLength(255);
            entity.Property(e => e.Manager).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.Position).HasMaxLength(100);
            entity.Property(e => e.Project).HasMaxLength(100);
            entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Skills).HasMaxLength(255);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.ZipCode).HasMaxLength(10);
        });

        modelBuilder.Entity<DataTypeTest>(entity =>
        {
            entity.ToTable("DataTypeTest");
            entity.HasKey(x => x.Id);

            entity.Property(x => x.Id).HasMaxLength(4000).HasColumnName("Id");
            entity.Property(x => x.JsonData).HasColumnName("JsonData");
            entity.Property(x => x.BinaryData).HasColumnName("BinaryData");
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.HasKey(e => e.ProfileId).HasName("PK__UserProf__290C888428AF2C71");

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.Bio).HasMaxLength(255);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProfilePicture).HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Website).HasMaxLength(255);

            entity.HasOne(d => d.User).WithMany(p => p.UserProfiles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__UserProfi__UserI__66603565");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
