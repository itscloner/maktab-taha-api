using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.province.Query.List
{
    public class GetProvinceListCommand : IRequest<OperationResult<List<Province>>>
    {
    }
}
