using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.orphanStatus.Query.List
{
    public class GetOrphanStatusListCommand : IRequest<OperationResult<List<OrphanStatus>>>
    {
    }
}
