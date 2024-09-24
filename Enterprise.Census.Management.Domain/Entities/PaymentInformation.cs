namespace Enterprise.Census.Management.Domain.Entities;
public class PaymentInformation : BaseEntity
{
    public string IBAN { get; set; }
    public long BankId { get; set; }
    public Bank Bank { get; set; }
    public string? CountryCode { get; set; }
    public long PersonId { get; set; }
    public virtual Person Person { get; set; }

}
