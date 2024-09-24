using Enterprise.Census.Management.Application.DTOs.Responses.Function;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Function;
public record CreateFunctionRquest(string FunctionName) : IRequest<CreateFunctionResponse>;
