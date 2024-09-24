﻿using Enterprise.Census.Management.Application.DTOs.Responses.EmploymentBond;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.EmploymentBond;
public record GetEmployeementBondRequest : IRequest<GetEmployeementBondResponse>;
