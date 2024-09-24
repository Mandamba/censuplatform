using Enterprise.Census.Management.Application.DTOs.Responses.Person;
using Enterprise.Census.Management.Application.Interfaces;
using Newtonsoft.Json;

namespace Enterprise.Census.Management.Application.Services;
public class ExternalPersonService : IExternalPersonService
{
    private readonly HttpClient _httpClient;
    public ExternalPersonService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<GetResponse> GetPersonDataFromApiAsync(string bi)
    {
        var requestUrl = $"https://www.sepe.gov.ao/ao/actions/bi.ajcall.php?bi={bi}";
        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var personResponse = JsonConvert.DeserializeObject<GetResponse>(content);


            return personResponse;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao buscar dados da API externa: {ex.Message}");
        }
    }
}