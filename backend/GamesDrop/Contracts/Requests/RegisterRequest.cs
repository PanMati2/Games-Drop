using System.ComponentModel.DataAnnotations;

namespace GamesDrop.Contracts.Requests
{
    public class RegisterRequest
    {
        [Required] [EmailAddress] public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 8, ErrorMessage = "The {0} must be between {1} and {2} characters length")]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$",
            ErrorMessage = "The {0} must contains small, big and alphanumeric letters")]
        public string Password { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 8, ErrorMessage = "The {0} must be between {1} and {2} characters length")]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$",
            ErrorMessage = "The {0} must contains small, big and alphanumeric letters")]
        [Compare("Password")]
        public string ConfirmedPassword { get; set; }
    }
}