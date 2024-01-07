using Gumtree.Server.Enums;
using System.ComponentModel.DataAnnotations;

namespace Gumtree.Server.Models
{
    public class RegistrationRequest
    {
        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Username { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        public Role Role { get; set; }
    }
}
