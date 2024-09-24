namespace Enterprise.Census.Management.Application.DTOs.Responses
{
    public record CreateWorkZoneResponse
    {
        public long Id { get; set; }
        public string JobZone { get; set; }
        public string StudentWorker { get; set; }
        public long WorkerStateId { get; set; }
        public string WorkerStateDesignation { get; set; }
        public int WorkerConditionId { get; set; }
        public string WorkerConditionName { get; set; }
        public string DirectManager { get; set; }
        public long PersonId { get; set; }
        public string PersonFullName { get; set; }
        public CreateWorkZoneResponse() { }
        public CreateWorkZoneResponse(
            long id,
            string jobZone,
            string studentWorker,
            long workerStateId,
            string workerStateDesignation,
            int workerConditionId,
            string workerConditionName,
            string directManager,
            long personId, string personFullName)
        {
            Id = id;
            JobZone = jobZone;
            StudentWorker = studentWorker;
            WorkerStateId = workerStateId;
            WorkerStateDesignation = workerStateDesignation;
            WorkerConditionId = workerConditionId;
            WorkerConditionName = workerConditionName;
            DirectManager = directManager;
            PersonId = personId;
            PersonFullName = personFullName;
        }
    }
}
