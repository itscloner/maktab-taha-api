using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.dependancyStatus.Query.List
{
    public class GetDependancyStatusListCommand : IRequest<OperationResult<List<DependancyStatus>>>
    {
    }
}
