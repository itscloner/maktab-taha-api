using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.role_permission.Command.Create
{
    public class CreateRolePermissionHandler : IRequestHandler<CreateRolePermissionCommand, OperationResult<RolePermission>>
    {
        private readonly IRolePermissionRepository _respository;
        private readonly IMapper _mapper;

        public CreateRolePermissionHandler(IRolePermissionRepository respository, IMapper mapper)
        {
            _respository = respository;
            _mapper = mapper;
        }

        public async Task<OperationResult<RolePermission>> Handle(CreateRolePermissionCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<RolePermission>();

            var mapped = _mapper.Map<RolePermission>(request);
            await _respository.Create(mapped);
            return operation.Succedded(mapped);
        }
    }
}
