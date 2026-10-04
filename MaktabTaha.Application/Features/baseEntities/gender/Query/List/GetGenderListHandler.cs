using AutoMapper;
using MaktabTaha.Application.Features.baseEntities.gender.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.gender.Query.List
{
    public class GetGenderListHandler : IRequestHandler<GetGenderListCommand, OperationResult<List<Gender>>>
    {
        private readonly IGenderRepository _repository;
        public GetGenderListHandler(IGenderRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Gender>>> Handle(GetGenderListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<Gender>>();

            var Genders = await _repository.List();

            return operation.Succedded(Genders);
        }
    }
}
