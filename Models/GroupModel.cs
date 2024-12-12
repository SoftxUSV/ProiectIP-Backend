using System.ComponentModel.DataAnnotations;

namespace ProiectIP.Models
{
    public class GroupModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int SpecializationId { get; set; }

        public SpecializationModel Specialization { get; set; }

        public int YearOfStudy { get; set; }

        [Range(5, 100)]
        public int Capacity { get; set; }

        public ICollection<ExamModel> Exams { get; set; }
    }
}