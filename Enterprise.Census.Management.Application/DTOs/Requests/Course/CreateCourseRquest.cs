using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests;
public record CreateCourseRquest(string Course, int ConclusionYear, long PersonId) : IRequest<CreateCourseResponse>;