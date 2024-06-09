using System.Linq.Expressions;

namespace CRM.Sigma.Data.Repositories.GenericRepositories
{
    /// <summary>
    /// Represents generic class repository interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Insert the entity entry
        /// </summary>
        /// <param name="entity">Entity entry</param>
        /// <param name="cancellationToken">For cancelling insert the entity entry</param>
        /// <returns></returns>
        Task InsertAsync(T entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the entity entry
        /// </summary>
        /// <param name="entity">Entity entry</param>
        void Update(T entity);

        /// <summary>
        /// Get the entity entry
        /// </summary>
        /// <param name="expression">Expression to get special entity entry</param>
        /// <param name="cancellationToken">For cancelling get the entity entry</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a bunch of items with special params
        /// </summary>
        /// <param name="expression">Expression to get entities</param>
        /// <param name="includeFunc">Delegate to get with included items</param>
        /// <param name="orderBy">Expression to define order by some props getting entities</param>
        /// <param name="isOrderByDescending">Parameter set default order by ascending</param>
        /// <param name="cancellationToken">For cancelling get entities</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task<IQueryable<T>> GetAllAsync(
           Expression<Func<T, bool>> expression,
           Func<IQueryable<T>, IQueryable<T>>? includeFunc = null,
           Expression<Func<T, object>>? orderBy = null,
           bool isOrderByDescending = false,
           CancellationToken cancellationToken = default);
    }
}
