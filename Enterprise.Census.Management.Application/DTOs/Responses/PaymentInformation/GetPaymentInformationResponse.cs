namespace Enterprise.Census.Management.Application.DTOs.Responses.PaymentInformation;
public record GetPaymentInformationResponse
{
    public long Id { get; set; }
    public int Iban { get; set; }
    public string Bank { get; set; }
    public string CountryCode { get; set; }
    public long PersonId { get; set; }
    public string PersonName { get; set; }

    public GetPaymentInformationResponse(long id, int iban,
        string bank, string countryCode, long personId,
        string personName)
    {
        Id = id;
        Iban = iban;
        Bank = bank;
        CountryCode = countryCode;
        PersonId = personId;
        PersonName = personName;
    }

}      
