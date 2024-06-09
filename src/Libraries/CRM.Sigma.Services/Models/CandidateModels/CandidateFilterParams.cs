using CRM.Sigma.Core.Utilities.Listing;

namespace CRM.Sigma.Services.Models.CandidateModels
{
    public class CandidateFilterParams : QueryStringParameters
    {
        public string? SearchFromEmail { get; set; } = string.Empty;
    }
}
