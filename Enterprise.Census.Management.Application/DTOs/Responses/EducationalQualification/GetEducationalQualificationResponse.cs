namespace Enterprise.Census.Management.Application.DTOs.Responses.EducationalQualification;
public record GetEducationalQualificationResponse(
    long Id,
    long DegreeId,
    string DegreeName,
    string Course,
    DateTime StartDate,
    string Specialty,
    long ConclusionYear,
    long TrainingCountryId,
    string TrainingCountryName,
    long PersonId,
    string PersonName
);
