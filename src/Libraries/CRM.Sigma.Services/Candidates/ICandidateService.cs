using CRM.Sigma.Core.Utilities.Listing;
using CRM.Sigma.Services.Models.CandidateModels;

namespace CRM.Sigma.Services.Candidates
{
    public interface ICandidateService
    {
        public Task<bool> CreateOrUpdateAsync(CandidateModel candidate);
        public Task<PagedList<CandidateModel>> GetAllAsync(CandidateFilterParams filterParams);
    }
}
