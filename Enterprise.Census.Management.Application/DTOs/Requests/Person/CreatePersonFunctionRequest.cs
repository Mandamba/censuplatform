using Enterprise.Census.Management.Application.DTOs.Responses.Person;
using Enterprise.Census.Management.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Person;
public record CreatePersonFunctionRequest
    (long FunctionId, string FunctionName, long PersonId,
    long CategoryId, string CategoryName, int DurationYear) : IRequest<CreatePersonFunctionResponse>;