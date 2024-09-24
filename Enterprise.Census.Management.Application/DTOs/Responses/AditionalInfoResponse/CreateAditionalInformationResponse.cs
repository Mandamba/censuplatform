namespace Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
public record CreateAditionalInformationResponse
{ 
    public long Id { get; set; }
    public string Description { get; set; }
    public long PersonId { get; set; }
    public CreateAditionalInformationResponse(long id, string description, long personId)
    {
        Id = id;
        Description = description;
        PersonId = personId;
    }
}

