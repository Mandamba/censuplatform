using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Persistence.Context;
using Enterprise.Census.Management.Persistence.Repositories;

namespace Enterprise.Census.Management.Domain.Interfaces;
public class WorkBandRepository : BaseRepository<WorkBand>, IWorkBandRepository
{
    public WorkBandRepository(ApplicationDbContext context) : base(context)
    {
    }
}