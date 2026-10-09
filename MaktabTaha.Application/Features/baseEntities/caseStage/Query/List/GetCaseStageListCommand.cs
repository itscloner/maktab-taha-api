using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.caseStage.Query.List
{
    public class GetCaseStageListCommand : IRequest<OperationResult<List<CaseStage>>>
    {
    }
}
