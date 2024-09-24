using Enterprise.Census.Management.Domain.Entities;

namespace Enterprise.Census.Management.Domain.Interfaces;
public interface IBaseRepository<T> where T : BaseEntity
{
    T Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> Get(long id, CancellationToken cancellationToken);
    Task<List<T>> GetAll(CancellationToken cancellationToken);
}