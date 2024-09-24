using Enterprise.Census.Management.Application.DTOs.Responses.Person;

namespace Enterprise.Census.Management.Application.Interfaces;
public interface IExternalPersonService
{
    Task<GetResponse> GetPersonDataFromApiAsync(string bi);
}