using Enterprise.Census.Management.Domain.Entities;

namespace Enterprise.Census.Management.Domain.Interfaces;
public interface IPersonRepository : IBaseRepository<Person>
{
    Task<Person> GetPersonWithRelations(long personId, CancellationToken cancellationToken);
    Task<Person> GetPersonByBI(string bi, CancellationToken cancellationToken);
}