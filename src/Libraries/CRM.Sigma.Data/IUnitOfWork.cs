using CRM.Sigma.Data.Repositories.Candidates;

namespace CRM.Sigma.Data
{
    /// <summary>
    /// Represents Unit of work pattern interface
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Represents candidate entity repository
        /// </summary>
        ICandidateRepository CandidateRepository { get; }

        /// <summary>
        /// To save changes
        /// </summary>
        /// <returns></returns>
        Task CommitAsync();

        /// <summary>
        /// To rollback changes
        /// </summary>
        /// <returns></returns>
        Task RollbackAsync();
    }
}
