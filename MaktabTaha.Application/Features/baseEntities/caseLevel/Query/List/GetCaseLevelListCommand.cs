using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.caseLevel.Query.List
{
    public class GetCaseLevelListCommand : IRequest<OperationResult<List<CaseLevel>>>
    {
    }
}
