using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ProiectIP.Models
{
    public class SpecializationModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int FacultyId { get; set; }

        public FacultyModel Faculty { get; set; }

        public ICollection<GroupModel> Groups { get; set; }
    }
}
