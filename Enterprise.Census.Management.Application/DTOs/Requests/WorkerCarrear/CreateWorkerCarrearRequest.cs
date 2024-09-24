using Enterprise.Census.Management.Application.DTOs.Requests.SpokenLanguage;
using Enterprise.Census.Management.Application.DTOs.Requests.WorkerFunction;

namespace Enterprise.Census.Management.Application.DTOs.Requests.WorkerCarrear;
public record CreateWorkerCarrearRequest
{
    public List<CreateSpokenLanguageRequest> Languages { get; set; }
    public List<CreateWorkerFunctionRequest> Functions { get; set; }

    public CreateWorkerCarrearRequest(List<CreateSpokenLanguageRequest> languages,
        List<CreateWorkerFunctionRequest> functions)
    {
        Languages = languages;
        Functions = functions;
    }
}