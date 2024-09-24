using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests;
public record CreateAiditionalTrainingRequest
    (string Course, long CompletionYear, long PersonId) : 
    IRequest<CreateAiditionalTrainingResponse>;
