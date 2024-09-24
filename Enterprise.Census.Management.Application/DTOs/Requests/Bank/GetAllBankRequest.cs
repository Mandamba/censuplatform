using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests;
public class GetAllBankRequest : IRequest<List<GetAllBankResponse>>;
