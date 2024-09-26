using Enterprise.Census.Management.Application.Interfaces;
using Enterprise.Census.Management.Application.Services;
using Enterprise.Census.Management.Domain.Interfaces;
using Enterprise.Census.Management.Persistence.Context;
using Enterprise.Census.Management.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Enterprise.Census.Management.Persistence;
public static class ServiceExtensions
{
    public static void ConfigurePersistenceApp(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString, optionsBuilder =>
            optionsBuilder.MigrationsAssembly("Enterprise.Census.Management.API")));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IContractTypeRepository, ContractTypeRepository>();
        services.AddScoped<ICoreRepository, CoreRepository>();
        services.AddScoped<IDirectionRepository, DirectionRepository>();
        services.AddScoped<IDivisionRepository, DivisionRepository>();
        services.AddScoped<IEducationalQualificationRepository, EducationalQualificationRepository>();
        services.AddScoped<IEmployerEntityRepository, EmployerEntityRepository>();
        services.AddScoped<IEmploymentBondRepository, EmploymentBondRepository>();
        services.AddScoped<IEmploymentInformationRepository, EmploymentInformationRepository>();
        services.AddScoped<IFrameWorkRepository, FrameWorkRepository>();
        services.AddScoped<IFunctionRepository, FunctionRepository>();
        services.AddScoped<IJobGroupRepository, JobGroupRepository>();
        services.AddScoped<ILanguagesRepository, LanguagesRepository>();
        services.AddScoped<IPaymentInformationRepository, PaymentInformationRepository>();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IPositionRepository, PositionRepository>();
        services.AddScoped<ISpokenLanguagesRepository, SpokenLanguagesRepository>();
        services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();
        services.AddScoped<IWorkBandRepository, WorkBandRepository>();
        services.AddScoped<IWorkerConditionRepository, WorkerConditionRepository>();
        services.AddScoped<IWorkerFunctionRepository, WorkerFunctionRepository>();
        services.AddScoped<IWorkerStateRepository, WorkerStateRepository>();
        services.AddScoped<IWorkRegimeRepository, WorkRegimeRepository>();
        services.AddScoped<IWorkZoneRepository, WorkZoneRepository>();
        services.AddScoped<IAditionalInformationRepository, AditionalInformationRepository>();
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<IAditionalTrainingRepository, AditionalTrainingRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<IDegreeRepository, DegreeRepository>();
        services.AddHttpClient<IExternalPersonService, ExternalPersonService>();
        services.AddScoped<ICarrearRepository, CarrearRepository>();
        services.AddScoped<ISpokenLanguagesRepository, SpokenLanguagesRepository>();
        services.AddScoped<IPersonFunctionRepository, PersonFunctionRepository>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<ISectionRepository, SectionRepository>();
        services.AddScoped<IProvinceRepository, ProvinceRepository>();
        services.AddScoped<IBankRepository, BankRepository>();
        services.AddScoped<IHouseHoldRepository, HouseHoldRepository>();
        services.AddScoped<IAuthRepository, AuthRepository>();
    }
}
