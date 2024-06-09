using AutoMapper;
using CRM.Sigma.Core.Utilities.Listing;
using CRM.Sigma.Data;
using CRM.Sigma.Data.Domain.Candidates;
using CRM.Sigma.Services.Models.CandidateModels;

namespace CRM.Sigma.Services.Candidates
{
    public class CandidateService : BaseService, ICandidateService
    {
        public CandidateService(IUnitOfWork unitOfWOrk, IMapper mapper) : base(unitOfWOrk, mapper)
        {
        }

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

        public async Task<PagedList<CandidateModel>> GetAllAsync(CandidateFilterParams filterParams)
        {
            throw new NotImplementedException();
        }
    }
}
