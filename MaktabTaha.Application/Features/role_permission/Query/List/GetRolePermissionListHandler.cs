using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.role_permission.Query.List
{
    public class GetRolePermissionListHandler : IRequestHandler<GetRolePermissionListCommand, OperationResult<List<RolePermission>>>
    {
        private readonly IRolePermissionRepository _respository;

        public GetRolePermissionListHandler(IRolePermissionRepository respository)
        {
            _respository = respository;
        }

        public async Task<OperationResult<List<RolePermission>>> Handle(GetRolePermissionListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<RolePermission>>();
            var permissions = await _respository.GetListWithoutIsDeleted();

            return operation.Succedded(permissions);
        }
    }
}
