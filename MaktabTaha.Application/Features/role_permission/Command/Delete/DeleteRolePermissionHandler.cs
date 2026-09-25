using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.role_permission.Command.Delete
{
    public class DeleteRolePermissionHandler : IRequestHandler<DeleteRolePermissionCommand, OperationResult<bool>>
    {
        private readonly IRolePermissionRepository _respository;
        private readonly IMapper _mapper;

        public DeleteRolePermissionHandler(IRolePermissionRepository respository, IMapper mapper)
        {
            _respository = respository;
            _mapper = mapper;
        }

        public async Task<OperationResult<bool>> Handle(DeleteRolePermissionCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();

            var rolePermission = await _respository.SingleOrDefault(x => x.RoleId == request.RoleId && x.PermissionId == request.PermissionId);
            if (rolePermission == null) return operation.Failure("مجوز یافت نشد");

            await _respository.Delete(rolePermission);
            return operation.Succedded(true);


        }
    }
}
