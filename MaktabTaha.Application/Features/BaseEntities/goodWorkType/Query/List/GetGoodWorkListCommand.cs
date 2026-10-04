using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.goodWorkType.Query.List
{
    public class GetGoodWorkTypeListCommand : IRequest<OperationResult<List<GoodWorkType>>>
    {
    }
}
