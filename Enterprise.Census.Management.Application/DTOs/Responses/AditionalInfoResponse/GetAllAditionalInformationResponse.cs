namespace Enterprise.Census.Management.Application.DTOs.Responses.AditionalInfoResponse;
public record GetAllAditionalInformationResponse
{
    public long Id { get; set; }
    public string Description { get; set; }
    public long PersonId { get; set; }
    public string PersonFullName { get; set; }
    public GetAllAditionalInformationResponse() { }
    public GetAllAditionalInformationResponse(long id, string description, long personId, string personFullName)
    {
        Id = id;
        Description = description;
        PersonId = personId;
        PersonFullName = personFullName;
    }
}

