using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Persistence.Context;
using Enterprise.Census.Management.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Enterprise.Census.Management.Domain.Interfaces;
public class WorkerConditionRepository : BaseRepository<WorkerCondition>, IWorkerConditionRepository
{
    private readonly ApplicationDbContext _context;
    public WorkerConditionRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<WorkerCondition>> GetAllWorkerConditionsAsync()
    {
        return await _context.WorkerConditions
                .Include(wc => wc.WorkerState)
                .ToListAsync();
    }
}