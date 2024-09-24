using Newtonsoft.Json;

namespace Enterprise.Census.Management.Application.DTOs.Responses.Person;
public class GetResponse
{
    [JsonProperty("sucess")]
    public bool Success { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("data")]
    public PersonData Data { get; set; }
}

public class PersonData
{
    [JsonProperty("numero")]
    public string IdentificationNumber { get; set; }

    [JsonProperty("nome")]
    public string FullName { get; set; }

    [JsonProperty("nif")]
    public string Nif { get; set; }

    [JsonProperty("data_nasc")]
    public DateTime DateOfBirth { get; set; }

    [JsonProperty("genero")]
    public string Gender { get; set; }

    [JsonProperty("naturalidade")]
    public string PlaceOfBirth { get; set; }

    [JsonProperty("pai_nome_completo")]
    public string FatherName { get; set; }

    [JsonProperty("mae_nome_completo")]
    public string MotherName { get; set; }

    [JsonProperty("estado_civil")]
    public string MaritalStatus { get; set; }

    [JsonProperty("data_emissao")]
    public DateTime IssuanceDate { get; set; }

    [JsonProperty("emissao_local")]
    public string IssuingPlace { get; set; }
}