using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebAPI.Models
{
    public class User
    {
        [Required]
        [NotNull]
        public string Username { get; set; }
        [Required]
        [NotNull]
        public string Password { get; set; }
        [Required]
        [NotNull]
        public string FirstName { get; set; }
        [Required]
        [NotNull]
        public string LastName { get; set; }
    }
}