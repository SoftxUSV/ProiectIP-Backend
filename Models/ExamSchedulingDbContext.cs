using Microsoft.EntityFrameworkCore;

namespace ProiectIP.Models
{
    public class ExamSchedulingDbContext : DbContext
    {
        public ExamSchedulingDbContext(DbContextOptions<ExamSchedulingDbContext> options) : base(options)
        {

        }

        public DbSet<FacultyModel> Faculties { get; set; }
        public DbSet<SpecializationModel> Specializations { get; set; }
        public DbSet<GroupModel> Groups { get; set; }
        public DbSet<ExamModel> Exams { get; set; }
        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // One-to-many relationship between Faculty and Specialization
            modelBuilder.Entity<FacultyModel>()
                .HasMany(f => f.Specializations)
                .WithOne(s => s.Faculty)
                .HasForeignKey(s => s.FacultyId);

            // One-to-many relationship between Specialization and Group
            modelBuilder.Entity<SpecializationModel>()
                .HasMany(s => s.Groups)
                .WithOne(g => g.Specialization)
                .HasForeignKey(g => g.SpecializationId);

            // One-to-many relationship between Group and Exam
            modelBuilder.Entity<GroupModel>()
                .HasMany(g => g.Exams)
                .WithOne(e => e.Group)
                .HasForeignKey(e => e.GroupId);
        }
    }
}
