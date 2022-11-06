using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8), MinLength(4)]
        public string Password { get; set; }
    }
}