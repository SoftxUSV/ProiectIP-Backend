using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ProiectIP.Models
{
    public class ExamModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime ScheduledDate { get; set; }

        [Required]
        public int GroupId { get; set; }

        public GroupModel? Group { get; set; }

        [Required]
        public int Duration { get; set; }

        [StringLength(200)]
        public string Location {  get; set; }
    }
}
