using CRM.Sigma.Core.Utilities.Listing;

namespace CRM.Sigma.Business.Models.CandidateModels
{
    public class CandidateFilterParams : QueryStringParameters
    {
        public string? SearchFromEmail { get; set; } = string.Empty;
    }
}
