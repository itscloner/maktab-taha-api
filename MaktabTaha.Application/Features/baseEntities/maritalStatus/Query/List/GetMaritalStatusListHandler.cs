using AutoMapper;
using MaktabTaha.Application.Features.baseEntities.maritalStatus.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.maritalStatus.Query.List
{
    public class GetMaritalStatusListHandler : IRequestHandler<GetMaritalStatusListCommand, OperationResult<List<MaritalStatus>>>
    {
        private readonly IMaritalStatusRepository _repository;
        public GetMaritalStatusListHandler(IMaritalStatusRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<MaritalStatus>>> Handle(GetMaritalStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<MaritalStatus>>();

            var MaritalStatuss = await _repository.List();

            return operation.Succedded(MaritalStatuss);
        }
    }
}
