using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using Enterprise.Census.Management.Persistence.Context;

namespace Enterprise.Census.Management.Persistence.Repositories;
public class AditionalInformationRepository : BaseRepository<AditionalInformation>, IAditionalInformationRepository
{
    public AditionalInformationRepository(ApplicationDbContext context) : base(context)
    {
    }
}