using CleanArchNet6Mine.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchNet6Mine.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
        {
        }

        public virtual DbSet<BuildVersion> BuildVersions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<BuildVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BuildVersion");

                entity.HasComment("Current version number of the AdventureWorksLT 2012 sample database. ");

                entity.Property(e => e.DatabaseVersion)
                    .HasMaxLength(25)
                    .HasColumnName("Database Version")
                    .HasComment("Version number of the database in 9.yy.mm.dd.00 format.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.SystemInformationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SystemInformationID")
                    .HasComment("Primary key for BuildVersion records.");

                entity.Property(e => e.VersionDate)
                    .HasColumnType("datetime")
                    .HasComment("Date and time the record was last updated.");
            });
        }
    }
}