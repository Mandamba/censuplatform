using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using Enterprise.Census.Management.Persistence.Context;

namespace Enterprise.Census.Management.Persistence.Repositories;
public class AditionalTrainingRepository : BaseRepository<AiditionalTraining>, IAditionalTrainingRepository
{
    public AditionalTrainingRepository(ApplicationDbContext context) : base(context)
    {
    }
}