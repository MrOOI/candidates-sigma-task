using CRM.Sigma.Data.Context;
using CRM.Sigma.Data.Repositories.Candidates;

namespace CRM.Sigma.Data
{
    /// <summary>
    /// Represents Unit of work pattern implementation
    /// </summary>
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _dbContext;
        private ICandidateRepository _candidateRepository;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ICandidateRepository CandidateRepository => _candidateRepository ?? (_candidateRepository = new CandidateRepository(_dbContext));

        /// <summary>
        /// To save changes
        /// </summary>
        /// <returns></returns>
        public async Task CommitAsync()
            => await _dbContext.SaveChangesAsync();

        /// <summary>
        /// To rollback changes
        /// </summary>
        /// <returns></returns>
        public async Task RollbackAsync()
            => await _dbContext.DisposeAsync();

        /// <summary>
        /// To dispose changes
        /// </summary>
        /// <returns></returns>
        public void Dispose()
        {
            ((IDisposable)_dbContext).Dispose();
        }

    }
}
