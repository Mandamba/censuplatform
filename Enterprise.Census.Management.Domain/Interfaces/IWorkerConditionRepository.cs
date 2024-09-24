using Enterprise.Census.Management.Domain.Entities;

namespace Enterprise.Census.Management.Domain.Interfaces;
public interface IWorkerConditionRepository : IBaseRepository<WorkerCondition>
{
    Task<List<WorkerCondition>> GetAllWorkerConditionsAsync();
}