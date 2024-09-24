﻿using Enterprise.Census.Management.Application.DTOs.Responses.Framework;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Framework;
public record CreateFrameWorkRequest(string Name) : IRequest<CreateFrameWorkResponse>;

