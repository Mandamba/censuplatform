﻿using Enterprise.Census.Management.Application.DTOs.Responses.EducationalQualification;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.EducationalQualification;
public record GetEducationalQualificationRequest : IRequest<GetEducationalQualificationResponse>;
