using System.ComponentModel.DataAnnotations;

namespace ProiectIP.Models
{
    public class FacultyModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<SpecializationModel> Specializations { get; set; }
    }
}
