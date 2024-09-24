namespace Enterprise.Census.Management.Application.DTOs.Responses;
public record CreateAiditionalTrainingResponse
{
    public long Id { get; set; } 
    public string Course { get; set; } 
    public long CompletionYear { get; set; } 
    public long PersonId { get; set; }
    public CreateAiditionalTrainingResponse() { }
    public CreateAiditionalTrainingResponse(
        long id, string course, long completionYear,
        long personId
        )
    {
        Id = id;
        Course = course;
        CompletionYear = completionYear;
        PersonId = personId;
    }
}
