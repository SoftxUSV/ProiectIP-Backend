using System.ComponentModel.DataAnnotations;

namespace ProiectIP.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(20)]
        public string Role { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; } // Added: User's email address

        [StringLength(15)]
        public string PhoneNumber { get; set; } // Added: User's phone number

        public DateTime DateCreated { get; set; } // Added: Account creation date
    }
}
