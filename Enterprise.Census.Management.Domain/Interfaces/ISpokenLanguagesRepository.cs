using Enterprise.Census.Management.Domain.Entities;

namespace Enterprise.Census.Management.Domain.Interfaces;
public interface ISpokenLanguagesRepository : IBaseRepository<SpokenLanguages>
{
    Task<SpokenLanguages> GetSpokenLanguagesByPersonIdAsync(long personId);
}