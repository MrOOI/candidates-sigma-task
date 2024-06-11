namespace CRM.Sigma.Business.Models.CandidateModels
{
    /// <summary>
    /// Represents a candidate model
    /// </summary>
    public class CandidateModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool CallIsRequired { get; set; }
        public string? ValidCallingTime { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? GithubUrl { get; set; }
        public string? Comment { get; set; }
    }
}
