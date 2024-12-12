using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace ProiectIP.Models
{
    public class ExamSchedulingDbContext : DbContext
    {
        public ExamSchedulingDbContext(DbContextOptions<ExamSchedulingDbContext> options) : base(options) { }

        public DbSet<FacultyModel> Faculties { get; set; }
        public DbSet<SpecializationModel> Specializations { get; set; }
        public DbSet<GroupModel> Groups { get; set; }
        public DbSet<ExamModel> Exams { get; set; }
        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Faculties
            modelBuilder.Entity<FacultyModel>().HasData(
                new FacultyModel { 
                    Id = 1, 
                    Name = "FIESC",
                    Description = "Facultatea de Inginerie Electrica si Stiinta Calculatoarelor",
                },
                new FacultyModel { Id = 2, Name = "FEAA", Description = "Facultatea de Economie, Administrație și Afaceri" }
            );

            // Seed Specializations
            modelBuilder.Entity<SpecializationModel>().HasData(
                new SpecializationModel { Id = 1, Name = "Calculatoare", FacultyId = 1, Overview = "" },
                new SpecializationModel { Id = 2, Name = "Automatica", FacultyId = 1 , Overview = "" },
                new SpecializationModel { Id = 3, Name = "Contabilitate", FacultyId = 2, Overview = "" }
            );

            // Seed Groups
            modelBuilder.Entity<GroupModel>().HasData(
                new GroupModel { Id = 1, Name = "3112b", SpecializationId = 1 },
                new GroupModel { Id = 2, Name = "4112a", SpecializationId = 2 },
                new GroupModel { Id = 3, Name = "5112a", SpecializationId = 3 }
            );

            // Seed Exams
            modelBuilder.Entity<ExamModel>().HasData(
                new ExamModel { Id = 1, Name = "Proiectarea Bazelor de Date", GroupId = 1, ScheduledDate = new DateTime(2024, 12, 1), Location = "C202" },
                new ExamModel { Id = 2, Name = "Matematici Speciale", GroupId = 2, ScheduledDate = new DateTime(2024, 12, 2), Location = "E101"}
            );

            modelBuilder.Entity<SpecializationModel>()
                .HasOne(s => s.Faculty)
                .WithMany(f => f.Specializations)
                .HasForeignKey(s => s.FacultyId);
        }
    }
}
