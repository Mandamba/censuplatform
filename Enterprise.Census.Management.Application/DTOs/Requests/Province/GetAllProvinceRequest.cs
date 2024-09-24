using Enterprise.Census.Management.Application.DTOs.Responses;
using MediatR;

namespace Enterprise.Census.Management.Application.DTOs.Requests.Province;
public class GetAllProvinceRequest : IRequest<List<GetAllProvinceResponse>>
{
}