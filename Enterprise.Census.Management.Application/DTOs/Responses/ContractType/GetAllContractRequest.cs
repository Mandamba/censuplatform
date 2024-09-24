namespace Enterprise.Census.Management.Application.DTOs.Responses.ContractType;
public record GetAllContractTypesResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public GetAllContractTypesResponse(long id, string name)
    {
        Id = id;
        Name = name;
    }
}

