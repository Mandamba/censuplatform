namespace Enterprise.Census.Management.Application.DTOs.Responses;
public record CreateHouseHoldResponse
{
    public bool IsMarried { get; set; }
    public long PersonId { get; set; }
    public int? NumberOfChildren { get; set; }
    public string? SpouseName { get; set; }
    public CreateHouseHoldResponse() { }
    public CreateHouseHoldResponse(bool isMarried, long personId, int numberOfChildren,
        string spouseName) { 
        IsMarried = isMarried;
        PersonId = personId;
        NumberOfChildren = numberOfChildren;
        SpouseName = spouseName;
    }
}