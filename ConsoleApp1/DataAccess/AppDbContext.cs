using ConsoleApp1.Core.Entity;
using EF_Relations.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace EF_Relations.DataAccess;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=EFTASK;Trusted_Connection=true;TrustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GroupStudent>()
            .HasKey(gs => new { gs.GroupId, gs.StudentId });

        modelBuilder.Entity<GroupStudent>()
            .HasOne(gs => gs.Group)
            .WithMany(g => g.GroupStudents)
            .HasForeignKey(gs => gs.GroupId);

        modelBuilder.Entity<GroupStudent>()
            .HasOne(gs => gs.Student)
            .WithMany(s => s.GroupStudents)
            .HasForeignKey(gs => gs.StudentId);
    }
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Group> Groups { get; set; } = null!;
}
