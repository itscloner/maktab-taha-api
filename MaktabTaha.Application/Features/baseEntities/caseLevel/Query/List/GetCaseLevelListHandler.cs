using AutoMapper;
using MaktabTaha.Application.Features.baseEntities.caseLevel.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.caseLevel.Query.List
{
    public class GetCaseLevelListHandler : IRequestHandler<GetCaseLevelListCommand, OperationResult<List<CaseLevel>>>
    {
        private readonly ICaseLevelRepository _repository;
        public GetCaseLevelListHandler(ICaseLevelRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<CaseLevel>>> Handle(GetCaseLevelListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<CaseLevel>>();

            var CaseLevels = await _repository.List();

            return operation.Succedded(CaseLevels);
        }
    }
}
