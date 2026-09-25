using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.role_permission.Query.Single
{
    public class GetRolePermissionByIdHandler : IRequestHandler<GetRolePermissionByIdCommand, OperationResult<RolePermission>>
    {
        private readonly IRolePermissionRepository _respository;

        public GetRolePermissionByIdHandler(IRolePermissionRepository respository)
        {
            _respository = respository;
        }

        public async Task<OperationResult<RolePermission>> Handle(GetRolePermissionByIdCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<RolePermission>();
            var rolePermission = await _respository.SingleOrDefault(x => x.RoleId == request.RoleId && x.PermissionId == request.PermissionId);
            if (rolePermission == null) return operation.Failure("مجوز یافت نشد");
            return operation.Succedded(rolePermission);
        }
    }
}
