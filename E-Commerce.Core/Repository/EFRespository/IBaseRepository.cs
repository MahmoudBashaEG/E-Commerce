using System.Linq.Expressions;

namespace E_Commerce.Core.Repository.EFRespository
{
    public interface IBaseRepository<T> where T : class
    {
        public Task Add(T entity);
        public Task AddRange(IEnumerable<T> entities);

        public Task Update(T entity);
        public Task UpdateRange(IEnumerable<T> entities);

        public Task Delete(T entity);
        public Task DeleteRange(IEnumerable<T> entities);

        public Task<T> FindOneAsync(Expression<Func<T, bool>> predicate, params string[] includes);
        public Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate, params string[] includes);
        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, params string[] includes);
    }
}
