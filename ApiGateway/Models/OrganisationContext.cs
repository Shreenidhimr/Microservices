using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiGateway.Models
{
    public partial class OrganisationContext : DbContext
    {
        public OrganisationContext()
        {
        }

        public OrganisationContext(DbContextOptions<OrganisationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Project> Project { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-8M9SE7LG;Initial Catalog=Organisation;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__Employee__C1971B538E631864");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate).HasColumnType("date");

                entity.Property(e => e.Project)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProjectNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.Project)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__Projec__2B3F6F97");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.Project1)
                    .HasName("PK__Project__DA68B0BD8BA33FD9");

                entity.Property(e => e.Project1)
                    .HasColumnName("Project")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
