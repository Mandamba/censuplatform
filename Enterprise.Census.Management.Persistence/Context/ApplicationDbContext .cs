using Enterprise.Census.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Enterprise.Census.Management.Persistence.Context;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }
     
    public DbSet<AditionalInformation> AditionalInformation { get; set; }
    public DbSet<AiditionalTraining> AiditionalTraining { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ContractType> ContractTypes { get; set; }
    public DbSet<Core> Cores { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Degree> Degrees { get; set; }
    public DbSet<Direction> Directions { get; set; }
    public DbSet<Division> Divisions { get; set; }
    public DbSet<EducationalQualification> EducationalQualifications { get; set; }
    public DbSet<EmployerEntity> EmployerEntities { get; set; }
    public DbSet<EmploymentBond> EmploymentBonds { get; set; }
    public DbSet<EmploymentInformation> EmploymentInformation { get; set; }
    public DbSet<FrameWork> FrameWorks { get; set; }
    public DbSet<Function> Functions { get; set; }
    public DbSet<JobGroup> JobGroups { get; set; }
    public DbSet<Languages> languages { get; set; }
    public DbSet<PaymentInformation> PaymentInformation { get; set; }
    public DbSet<Person> Person { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<SpokenLanguages> SpokenLanguages { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<WorkBand> WorkBands { get; set; }
    public DbSet<WorkerCondition> WorkerConditions { get; set; }
    public DbSet<WorkerFunction> WorkerFunctions { get; set; }
    public DbSet<WorkerState> WorkerStates { get; set; }
    public DbSet<WorkRegime> WorkRegimes { get; set; }
    public DbSet<WorkZone> WorkZones { get; set; }
    public DbSet<Courses> Courses { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<Bank> Banks { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<WorkZone>()
       .HasOne(wz => wz.WorkerState)
       .WithMany()
       .HasForeignKey(wz => wz.WorkerStateId)
       .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<WorkZone>()
            .HasOne(wz => wz.WorkerCondition)
            .WithMany()
            .HasForeignKey(wz => wz.WorkerConditionId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<WorkZone>()
            .HasOne(wz => wz.Person)
            .WithMany()
            .HasForeignKey(wz => wz.PersonId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}