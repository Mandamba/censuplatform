﻿using Enterprise.Census.Management.Application.DTOs.Responses.WorkRegime;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.WorkRegime;
public record GetWorkRegimeRequest : IRequest<GetWorkRegimeResponse>;
