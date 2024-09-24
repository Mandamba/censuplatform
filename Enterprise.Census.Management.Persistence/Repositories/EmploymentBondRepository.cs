using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Persistence.Context;
using Enterprise.Census.Management.Persistence.Repositories;

namespace Enterprise.Census.Management.Domain.Interfaces;
public class EmploymentBondRepository : BaseRepository<EmploymentBond>, IEmploymentBondRepository
{
    public EmploymentBondRepository(ApplicationDbContext context) : base(context)
    {
    }
}