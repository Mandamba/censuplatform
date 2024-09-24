using Enterprise.Census.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Census.Management.Domain.Interfaces;
public interface IWorkerFunctionRepository : IBaseRepository<WorkerFunction>
{
    Task<WorkerFunction> GetWorkerFunctionByPersonIdAsync(long personId);
}