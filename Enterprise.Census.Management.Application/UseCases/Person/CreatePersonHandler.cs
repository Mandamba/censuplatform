using AutoMapper;
using Enterprise.Census.Management.Application.DTOs.Requests;
using Enterprise.Census.Management.Application.DTOs.Responses;
using Enterprise.Census.Management.Domain.Entities;
using Enterprise.Census.Management.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Census.Management.Application.UseCases;
public class CreatePersonHandler : IRequestHandler<CreatePersonRequest, CreatePersonResponse>
{
    private readonly IMapper _mapper;
    private readonly IPersonRepository _personRepository;
    private readonly IEmploymentInformationRepository _employmentRepository;
    private readonly IWorkZoneRepository _workZoneRepository;
    private readonly IPaymentInformationRepository _paymentRepository;
    private readonly IEducationalQualificationRepository _educationalRepository;
    private readonly IWorkerFunctionRepository _workerFunctionRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAditionalTrainingRepository _aditionalTrainingRepository;
    private readonly ISpokenLanguagesRepository _spkenLanguagesRepository;
    private readonly IHouseHoldRepository _houseHoldRepository;

    public CreatePersonHandler(
        IMapper mapper,
        IPersonRepository personRepository,
        IEmploymentInformationRepository employmentRepository,
        IWorkZoneRepository workZoneRepository,
        IPaymentInformationRepository paymentRepository,
        IEducationalQualificationRepository educationalRepository,
        IWorkerFunctionRepository workerFunctionRepository,
        IUnitOfWork unitOfWork,
        IAditionalTrainingRepository aditionalTrainingRepository,
        ISpokenLanguagesRepository spkenLanguagesRepository,
        IHouseHoldRepository houseHoldRepository)
    {
        _mapper = mapper;
        _personRepository = personRepository;
        _employmentRepository = employmentRepository;
        _workZoneRepository = workZoneRepository;
        _paymentRepository = paymentRepository;
        _educationalRepository = educationalRepository;
        _workerFunctionRepository = workerFunctionRepository;
        _unitOfWork = unitOfWork;
        _aditionalTrainingRepository = aditionalTrainingRepository;
        _spkenLanguagesRepository = spkenLanguagesRepository;
        _houseHoldRepository = houseHoldRepository;
    }

    public async Task<CreatePersonResponse> Handle(CreatePersonRequest request, CancellationToken cancellationToken)
    {
        await _unitOfWork.BeginTransactionAsync(cancellationToken);
        try
        {
            var existingPerson = await _personRepository.GetPersonByBI(request.IdentificationNumber, cancellationToken);
            if (existingPerson != null)
            {
                return new CreatePersonResponse
                {
                    ExistedPersonSuccess = false,
                    Message = "A pessoa com este número de BI já está registrada."
                };
            }

            var person = new Person
            {
                IdentificationNumber = request.IdentificationNumber,
                FullName = request.FullName,
                FatherName = request.FatherName,
                MotherName = request.MotherName,
                Residence = request.Residence,
                PlaceOfBirth = request.PlaceOfBirth,
                Province = request.Province,
                DateOfBirth = request.DateOfBirth,
                Gender = request.Gender,
                IssuingPlace = request.IssuingPlace,
                ExpirationDate = request.ExpirationDate,
                PhoneNumber = request.PhoneNumber,
                UpdatedPhoneNumber = request.UpdatedPhoneNumber,
                Nif = request.Nif,
                SocialSecurityNumber = request.SocialSecurityNumber,
                AlternativeContact = request.AlternativeContact,
                AlternativeContactName = request.AlternativeContactName,
                AditionalInformation = request.AditionalInformation
            };
            var createdPerson = _personRepository.Create(person);
            await _unitOfWork.Commit(cancellationToken);

            await SaveRelatedData(request, createdPerson.Id, cancellationToken);

            await _unitOfWork.CommitTransactionAsync(cancellationToken);

            var personWithRelations = await _personRepository.GetPersonWithRelations(createdPerson.Id, cancellationToken);
            return _mapper.Map<CreatePersonResponse>(personWithRelations);
        }
            catch (Exception ex)
        {
            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
            throw;
        }
    }

    private async Task SaveRelatedData(CreatePersonRequest request, long personId, CancellationToken cancellationToken)
    {
        if (request.CreateEmploymentInformation != null)
        {
            var employment = _mapper.Map<EmploymentInformation>(request.CreateEmploymentInformation);
            employment.PersonId = personId;
            _employmentRepository.Create(employment);
            await _unitOfWork.Commit(cancellationToken);
        }
        if (request.CreateWorkZone != null)
        {
            var workZone = _mapper.Map<WorkZone>(request.CreateWorkZone);
            workZone.PersonId = personId;
            _workZoneRepository.Create(workZone);
            await _unitOfWork.Commit(cancellationToken);
        }
        if (request.CreatePaymentInformation != null)
        {
            var payment = _mapper.Map<PaymentInformation>(request.CreatePaymentInformation);
            payment.PersonId = personId;
            _paymentRepository.Create(payment);
            await _unitOfWork.Commit(cancellationToken);
        }
        if (request.CreateEducational != null)
        {
            var educational = _mapper.Map<EducationalQualification>(request.CreateEducational);
            educational.PersonId = personId;
            _educationalRepository.Create(educational);
            foreach (var aditionalTraining in educational.AiditionalTraining)
            {
                var mappedAditionalTraining = _mapper.Map<AiditionalTraining>(aditionalTraining);
                mappedAditionalTraining.PersonId = personId;
                _aditionalTrainingRepository.Create(mappedAditionalTraining); 
            }
            await _unitOfWork.Commit(cancellationToken);
        }
        if (request.CreateWorkerCarrears != null)
        {
            foreach (var functionRequest in request.CreateWorkerCarrears.Functions)
            {
                var workerFunction = _mapper.Map<WorkerFunction>(functionRequest);
                workerFunction.PersonId = personId;
                _workerFunctionRepository.Create(workerFunction);
            }
            foreach (var language in request.CreateWorkerCarrears.Languages)
            {
                var mappedSpokenLanguage = _mapper.Map<SpokenLanguages>(language); 
                mappedSpokenLanguage.PersonId = personId;
                _spkenLanguagesRepository.Create(mappedSpokenLanguage);
            }
            await _unitOfWork.Commit(cancellationToken);
        }
        if (request.CreateHouseHold != null)
        {
            var mappedHouseHold = _mapper.Map<HouseHold>(request.CreateHouseHold);
            mappedHouseHold.PersonId = personId;
            _houseHoldRepository.Create(mappedHouseHold);
            await _unitOfWork.Commit(cancellationToken);
        }
    }
}
