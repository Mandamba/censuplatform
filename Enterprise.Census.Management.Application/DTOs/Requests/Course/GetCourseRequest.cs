using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests;
public record GetCourseRequest(string Course, int ConclusionYear, long PersonId) : IRequest<GetCourseResponse>;
