namespace Enterprise.Census.Management.Application.DTOs.Responses.EducationalQualification;
public record GetAllEducationalQualificationsResponse(
    List<GetEducationalQualificationResponse> EducationalQualifications
);