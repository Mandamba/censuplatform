namespace Enterprise.Census.Management.Application.DTOs.Responses.WorkerFunction
{
    public record CreateWorkerFunctionResponse
    {
        public long FunctionId { get; set; }
        public string FunctionName { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public long PersonId { get; set; }
        public string PersonName { get; set; }
        public int DurationYear { get; set; }
        public CreateWorkerFunctionResponse() { }
        public CreateWorkerFunctionResponse(
            long functionId,
            string functionName,
            long categoryId,
            string categoryName,
            long personId,
            string personName,
            int durationYear)
        {
            FunctionId = functionId;
            FunctionName = functionName;
            CategoryId = categoryId;
            CategoryName = categoryName;
            PersonId = personId;
            PersonName = personName;
            DurationYear = durationYear;
        }
    }
}
