using Enterprise.Census.Management.Application.DTOs.Responses.SpokenLanguage;
using Enterprise.Census.Management.Application.DTOs.Responses.WorkerFunction;

namespace Enterprise.Census.Management.Application.DTOs.Responses.WorkerCarrear;
public class CreateWorkerCarrearResponse
{
    public List<CreateSpokenLanguageResponse> Languages { get; set; }
    public List<CreateWorkerFunctionResponse> Functions { get; set; }

    public CreateWorkerCarrearResponse() { }
    public CreateWorkerCarrearResponse(List<CreateSpokenLanguageResponse> languages,
        List<CreateWorkerFunctionResponse> functions)
    {
        Languages = languages;
        Functions = functions;
    }
}