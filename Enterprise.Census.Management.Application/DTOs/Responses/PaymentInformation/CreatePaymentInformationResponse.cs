namespace Enterprise.Census.Management.Application.DTOs.Responses.PaymentInformation;
public record CreatePaymentInformationResponse
{
    public long Id { get; set; }
    public string Iban { get; set; }
    public string Bank { get; set; }
    public string CountryCode { get; set; }
    public long PersonId { get; set; }
    public string PersonName { get; set; }
    public CreatePaymentInformationResponse() { }
    public CreatePaymentInformationResponse(long id, string iban,
        string bank, string countryCode, long personId, string personName)
    {
        Id = id;
        Iban = iban;
        Bank = bank;
        CountryCode = countryCode;
        PersonId = personId;
        PersonName = personName;
    }
}
