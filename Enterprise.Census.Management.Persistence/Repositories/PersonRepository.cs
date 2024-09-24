using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Persistence.Context;
using Enterprise.Census.Management.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Enterprise.Census.Management.Domain.Interfaces;
public class PersonRepository : BaseRepository<Person>, IPersonRepository
{
    private readonly ApplicationDbContext _context;
    public PersonRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Person> GetPersonWithRelations(long personId, CancellationToken cancellationToken)
    {
        return await _context.Person 
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.Position)
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.Division)
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.Direction)
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.Core)
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.Category)
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.SubCategory)
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.JobGroup)
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.ContractType)
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.EmploymentBond)
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.WorkRegime)
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.FrameWork)
        .Include(p => p.EmploymentInformation)
            .ThenInclude(e => e.Section)
        .Include(p => p.EmploymentInformation)
        .ThenInclude(e => e.Department)
        .Include(p => p.WorkZone)
          .ThenInclude(s => s.WorkerState)
        .Include(p => p.WorkZone)
            .ThenInclude(c => c.WorkerCondition) 
        .Include(p => p.PaymentInformation)
            .ThenInclude(b => b.Bank)
        .Include(p => p.EducationalQualification)
            .ThenInclude(eq => eq.AiditionalTraining)
        .Include(p => p.EducationalQualification)
            .ThenInclude(eq => eq.TrainingCountry)
        .Include(d => d.EducationalQualification)
            .ThenInclude(d => d.Degree)
        .Include(p => p.SpokenLanguages)
            .ThenInclude(l => l.Languages)
        .Include(wf => wf.WorkerFunctions)
            .ThenInclude(f => f.Function)
        .Include(wf => wf.WorkerFunctions)
            .ThenInclude(c => c.Category)
        .Include(p => p.HouseHold) 
        .FirstOrDefaultAsync(p => p.Id == personId, cancellationToken);
    }
}