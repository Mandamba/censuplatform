using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Persistence.Context;
using Enterprise.Census.Management.Persistence.Repositories;

namespace Enterprise.Census.Management.Domain.Interfaces;
public class EmploymentInformationRepository : BaseRepository<EmploymentInformation>, IEmploymentInformationRepository
{
    public EmploymentInformationRepository(ApplicationDbContext context) : base(context)
    {}
}