using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.role.Query.single
{
    public class GetRoleByIdHandler : IRequestHandler<GetRoleByIdCommand, OperationResult<Role>>
    {
        private readonly IRoleRepository _repository;

        public GetRoleByIdHandler(IRoleRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<Role>> Handle(GetRoleByIdCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<Role>();
            var role = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (role == null) return operation.Failure("نقش یافت نشد");

            return operation.Succedded(role);

        }
    }
}
