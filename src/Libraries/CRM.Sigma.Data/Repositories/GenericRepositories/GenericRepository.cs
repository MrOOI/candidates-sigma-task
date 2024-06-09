using CRM.Sigma.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CRM.Sigma.Data.Repositories.GenericRepositories
{
    /// <summary>
    /// Represents the entity repository implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _dbContext;
        private readonly DbSet<T> _entitiySet;

        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _entitiySet = _dbContext.Set<T>();
        }

        /// <summary>
        /// Get a bunch of items with special params
        /// </summary>
        /// <param name="expression">Expression to get entities</param>
        /// <param name="includeFunc">Delegate to get with included items</param>
        /// <param name="orderBy">Expression to define order by some props getting entities</param>
        /// <param name="isOrderByDescending">Parameter set default order by ascending</param>
        /// <param name="cancellationToken">For cancelling get entities</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains entities
        /// </returns>
        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IQueryable<T>>? includeFunc = null,
            Expression<Func<T, object>>? orderBy = null,
            bool isOrderByDescending = false,
            CancellationToken cancellationToken = default)
        {
            var result = _entitiySet.Where(expression);

            // Include related entities if includeFunc is provided
            result = includeFunc == null ? result : includeFunc(result);
            result = orderBy == null ? result : isOrderByDescending
            ? result.OrderByDescending(orderBy)
            : result.OrderBy(orderBy);

            return result;
        }

        /// <summary>
        /// Get the entity entry
        /// </summary>
        /// <param name="expression">Expression to get special entity entry</param>
        /// <param name="cancellationToken">For cancelling get the entity entry</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        public async Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
            => await _entitiySet.FirstOrDefaultAsync(expression, cancellationToken);

        /// <summary>
        /// Insert the entity entry
        /// </summary>
        /// <param name="entity">Entity entry</param>
        /// <param name="cancellationToken">For cancelling insert the entity entry</param>
        /// <returns></returns>
        public async Task InsertAsync(T entity, CancellationToken cancellationToken = default)
            => await _dbContext.AddAsync(entity, cancellationToken);

        /// <summary>
        /// Update the entity entry
        /// </summary>
        /// <param name="entity">Entity entry</param>
        public void Update(T entity)
            => _dbContext.Update(entity);
    }
}
