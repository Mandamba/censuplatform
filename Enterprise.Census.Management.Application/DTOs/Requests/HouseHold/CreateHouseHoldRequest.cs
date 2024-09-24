using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests;
public record CreateHouseHoldRequest(bool isMarried, string numberOfChildren,
    string spouseName) : IRequest<CreateHouseHoldResponse>
{}