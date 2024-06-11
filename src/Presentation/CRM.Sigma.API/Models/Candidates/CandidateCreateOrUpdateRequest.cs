using System.ComponentModel.DataAnnotations;

namespace CRM.Sigma.API.Models.Candidates
{
    public class CandidateCreateOrUpdateRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public bool CallIsRequired { get; set; }

        public string? ValidCallingTime { get; set; }

        public string? LinkedInUrl { get; set; }

        public string? GithubUrl { get; set; }

        public string? Comment { get; set; }
    }
}
