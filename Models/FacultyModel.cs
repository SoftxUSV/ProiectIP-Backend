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

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public DateTime EstablishedDate { get; set; }

        public ICollection<SpecializationModel> Specializations { get; set; }
    }
}
