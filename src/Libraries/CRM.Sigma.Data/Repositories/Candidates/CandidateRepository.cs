using CRM.Sigma.Data.Context;
using CRM.Sigma.Data.Domain.Candidates;
using CRM.Sigma.Data.Repositories.GenericRepositories;

namespace CRM.Sigma.Data.Repositories.Candidates
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
 