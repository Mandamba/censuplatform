using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Persistence.Context;
using Enterprise.Census.Management.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Enterprise.Census.Management.Domain.Interfaces;
public class SpokenLanguagesRepository : BaseRepository<SpokenLanguages>, ISpokenLanguagesRepository
{
    private readonly ApplicationDbContext _context;
    public SpokenLanguagesRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<SpokenLanguages> GetSpokenLanguagesByPersonIdAsync(long personId)
    {
        return await _context.SpokenLanguages
            .Where(wf => wf.PersonId == personId).FirstOrDefaultAsync();
    }
}