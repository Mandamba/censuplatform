using Enterprise.Census.Management.Application.DTOs.Responses.EducationalQualification;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.EducationalQualification;
public record CreateEducationalQualificationRequest(
        long DegreeId,
        string Course,
        DateTime StartDate,
        string Specialty,
        long ConclusionYear,
        long TrainingCountryId,
        long PersonId,
        List<CreateAiditionalTrainingRequest> CreateAiditionalTraining
    ) : IRequest<CreateEducationalQualificationResponse>;
