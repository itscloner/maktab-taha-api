using AutoMapper;
using MaktabTaha.Application.Features.baseEntities.dependancyStatus.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.dependancyStatus.Query.List
{
    public class GetDependancyStatusListHandler : IRequestHandler<GetDependancyStatusListCommand, OperationResult<List<DependancyStatus>>>
    {
        private readonly IDependancyStatusRepository _repository;
        public GetDependancyStatusListHandler(IDependancyStatusRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<DependancyStatus>>> Handle(GetDependancyStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<DependancyStatus>>();

            var DependancyStatuss = await _repository.List();

            return operation.Succedded(DependancyStatuss);
        }
    }
}
