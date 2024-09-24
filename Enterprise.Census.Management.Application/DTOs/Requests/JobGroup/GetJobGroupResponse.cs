using Enterprise.Census.Management.Application.DTOs.Responses.JobGroup;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.JobGroup;
public record GetJobGroupRequest : IRequest<GetJobGroupResponse>;
