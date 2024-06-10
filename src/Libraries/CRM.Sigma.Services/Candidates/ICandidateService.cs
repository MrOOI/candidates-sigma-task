using CRM.Sigma.Core.Utilities.Listing;
using CRM.Sigma.Services.Models.CandidateModels;

namespace CRM.Sigma.Services.Candidates
{

    /// <summary>
    /// Represents candidate service interface 
    /// </summary>
    public interface ICandidateService
    {

        /// <summary>
        /// Represents creating or updating candidate 
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        public Task<bool> CreateOrUpdateAsync(CandidateModel candidate);

        /// <summary>
        /// Getting all candidates according to filter parameters
        /// </summary>
        /// <param name="filterParams"></param>
        /// <returns></returns>
        public Task<PagedList<CandidateModel>> GetAllAsync(CandidateFilterParams filterParams);
    }
}
