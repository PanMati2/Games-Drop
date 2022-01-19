using System.ComponentModel.DataAnnotations;

namespace GamesDrop.Contracts.Requests
{
    public class LoginRequest
    {
        [Required] [EmailAddress] public string Email { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 8, ErrorMessage = "Hasło musi posiada minimum {1} a maximum {2} znaków")]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$",
            ErrorMessage = "Hasło musi zawierać małe, duże i numeryczny znaki")]
        public string Password { get; set; }
    }
}