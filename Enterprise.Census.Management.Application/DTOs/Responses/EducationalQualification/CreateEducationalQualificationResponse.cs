using Enterprise.Census.Management.Application.UseCases;
using Enterprise.Census.Management.Domain.Entities;

namespace Enterprise.Census.Management.Application.DTOs.Responses.EducationalQualification;
public record CreateEducationalQualificationResponse {
    public long Id { get; set; }
    public long DegreeId { get; set; }
    public string DegreeName { get; set; }
    public string Course { get; set; }
    public DateTime StartDate { get; set; }
    public string Specialty { get; set; }
    public long ConclusionYear { get; set; }
    public long TrainingCountryId { get; set; }
    public string TrainingCountryName { get; set; }
    public long PersonId { get; set; }
    public string PersonName { get; set; }
    public List<CreateAiditionalTrainingResponse> CreateAiditionalTraining { get; set; }
    public CreateEducationalQualificationResponse() { }
    public CreateEducationalQualificationResponse(long id, long degreeId,string degreeName,
        string course, DateTime startDate, string specialty, 
        long conclusionYear, long trainningCountryId, string trainningCountryName,
        long personId, string personName, List<CreateAiditionalTrainingResponse> createAiditionalTraining)
    {
        Id = id;
        DegreeId = degreeId;
        DegreeName = degreeName;
        Course = course;
        StartDate = startDate;
        Specialty = specialty;
        ConclusionYear = conclusionYear;
        TrainingCountryId = trainningCountryId;
        TrainingCountryName = trainningCountryName;
        PersonId = personId;
        PersonName = personName;
        CreateAiditionalTraining = createAiditionalTraining;
    }
}
