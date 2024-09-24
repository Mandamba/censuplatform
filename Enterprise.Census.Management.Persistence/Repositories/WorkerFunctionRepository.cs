using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Persistence.Context;
using Enterprise.Census.Management.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Enterprise.Census.Management.Domain.Interfaces;
public class WorkerFunctionRepository : BaseRepository<WorkerFunction>, IWorkerFunctionRepository
{
    private readonly ApplicationDbContext _context;
    public WorkerFunctionRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<WorkerFunction> GetWorkerFunctionByPersonIdAsync(long personId)
    {
        return await _context.WorkerFunctions
            .Where(wf => wf.PersonId == personId).FirstOrDefaultAsync();
    }
}