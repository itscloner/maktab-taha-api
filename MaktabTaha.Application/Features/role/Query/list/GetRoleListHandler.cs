using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.role.Query.list
{
    public class GetRoleListHandler : IRequestHandler<GetRoleListCommand, OperationResult<List<Role>>>
    {
        private readonly IRoleRepository _repository;

        public GetRoleListHandler(IRoleRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Role>>> Handle(GetRoleListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<Role>>();
            var roles = await _repository.List();
            return operation.Succedded(roles);

        }
    }
}
