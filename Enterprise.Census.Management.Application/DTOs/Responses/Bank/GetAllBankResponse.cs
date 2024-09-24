namespace Enterprise.Census.Management.Application.DTOs.Responses;
public record GetAllBankResponse
{
    public long Id { get; set; }
    public string Code { get; set; }
    public string BankName { get; set; }
    public GetAllBankResponse(string bankName, string code, long id)
    {
        Id = id;
        BankName = bankName;
        Code = code;
    }
}