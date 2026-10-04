using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.houseHeadStatus.Query.List
{
    public class GetHouseHeadStatusListCommand : IRequest<OperationResult<List<HouseHeadStatus>>>
    {
    }
}
