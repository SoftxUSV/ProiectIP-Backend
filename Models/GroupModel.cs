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

        public ICollection<ExamModel> Exams { get; set; }
    }
}