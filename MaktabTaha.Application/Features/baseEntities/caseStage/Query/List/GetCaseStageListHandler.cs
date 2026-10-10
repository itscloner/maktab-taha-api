using AutoMapper;
using MaktabTaha.Application.Features.baseEntities.caseStage.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.caseStage.Query.List
{
    public class GetCaseStageListHandler : IRequestHandler<GetCaseStageListCommand, OperationResult<List<CaseStage>>>
    {
        private readonly ICaseStageRepository _repository;
        public GetCaseStageListHandler(ICaseStageRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<CaseStage>>> Handle(GetCaseStageListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<CaseStage>>();

            var CaseStagess = await _repository.List();

            return operation.Succedded(CaseStagess);
        }
    }
}
