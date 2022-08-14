namespace Ibrahimogod.Repository.Repositories;

public interface IRepository<TEntity> where TEntity : class, IEntity
{
    Task<TEntity> GetByIdAsync(int id);

    Task<TEntity> GetAllAsync(Func<IQueryable<TEntity>,IQueryable<TEntity>> filter = null);

    Task<TEntity> FilterAsync(Predicate<TEntity> predicate);


}
