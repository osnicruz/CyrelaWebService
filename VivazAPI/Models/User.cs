using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VivazAPI.Models
{
    [Table("users")]
    public class User : BaseEntity
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        // TODO: use enum
        [Required]
        public string Role { get; set; }
    }
}