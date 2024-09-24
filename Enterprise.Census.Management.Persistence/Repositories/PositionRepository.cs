using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Persistence.Context;
using Enterprise.Census.Management.Persistence.Repositories;

namespace Enterprise.Census.Management.Domain.Interfaces;
public class PositionRepository : BaseRepository<Position>, IPositionRepository
{
    public PositionRepository(ApplicationDbContext context) : base(context)
    {
    }
}