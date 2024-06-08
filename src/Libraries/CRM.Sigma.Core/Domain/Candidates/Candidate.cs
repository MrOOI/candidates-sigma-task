using CRM.Sigma.Core;

namespace CRM.Sigma.Data.Domain.Candidates
{
    /// <summary>
    /// Represents a candidate
    /// </summary>
    public partial class Candidate : BaseEntity
    {
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the email
        /// </summary>
        public string Email { get; set;}

        /// <summary>
        /// Gets or sets call is needed
        /// </summary>
        public bool CallIsRequired { get; set; }

        /// <summary>
        /// Gets or sets the time interval when it’s better to call candidate
        /// </summary>
        public string? ValidCallingTime { get; set;}

        /// <summary>
        /// Gets or sets LinkedIn profile URL
        /// </summary>
        public string? LinkedInUrl { get; set; }

        /// <summary>
        /// Gets or sets Github profile URL
        /// </summary>
        public string? GithubUrl { get; set; }

        /// <summary>
        /// Gets or sets free text comment
        /// </summary>
        public string? Comment { get; set; }
    }
}
