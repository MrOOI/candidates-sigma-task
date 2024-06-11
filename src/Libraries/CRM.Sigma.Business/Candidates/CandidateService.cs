using AutoMapper;
using AutoMapper.QueryableExtensions;
using CRM.Sigma.Core.Utilities.Listing;
using CRM.Sigma.Data;
using CRM.Sigma.Data.Domain.Candidates;
using CRM.Sigma.Business.Models.CandidateModels;
using Microsoft.IdentityModel.Tokens;

namespace CRM.Sigma.Business.Candidates
{
    /// <summary>
    /// Represents candidate service methods
    /// </summary>
    public class CandidateService : BaseService, ICandidateService
    {
        public CandidateService(IUnitOfWork unitOfWOrk, IMapper mapper) : base(unitOfWOrk, mapper)
        {
        }

        /// <summary>
        /// Represents creating or updating candidate 
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        public async Task<bool> CreateOrUpdateAsync(CandidateModel candidate)
        {
            var oldCandidate = await UnitOfWork.CandidateRepository.GetAsync(item => item.Email == candidate.Email);
            if (oldCandidate != null)
            {
                Mapper.Map(candidate, oldCandidate);
                UnitOfWork.CandidateRepository.Update(oldCandidate);
                await UnitOfWork.CommitAsync();
                return true;
            }

            var newCandidate = Mapper.Map<Candidate>(candidate);
            await UnitOfWork.CandidateRepository.InsertAsync(newCandidate);
            await UnitOfWork.CommitAsync();
            return true;
        }

        /// <summary>
        /// Getting all candidates according to filter parameters
        /// </summary>
        /// <param name="filterParams"></param>
        /// <returns></returns>
        public async Task<PagedList<CandidateModel>> GetAllAsync(CandidateFilterParams filterParams)
        {
            var resultItems = await UnitOfWork.CandidateRepository.GetAllAsync(item=>
                (filterParams.SearchFromEmail.IsNullOrEmpty() || item.Email.ToLower().Contains(filterParams.SearchFromEmail)), null, null, filterParams.Order =="desc");

            var items = resultItems.ProjectTo<CandidateModel>(Mapper.ConfigurationProvider);

            PagedList<CandidateModel> pagedList = PagedList<CandidateModel>.ToPagedListFromQuery(
                filterParams.PageNumber,
                filterParams.PageSize,
                filterParams.Order,
                items);

            return pagedList;
        }
    }
}
