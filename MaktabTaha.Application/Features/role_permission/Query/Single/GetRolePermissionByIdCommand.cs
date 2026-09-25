using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.role_permission.Query.Single
{
    public class GetRolePermissionByIdCommand : IRequest<OperationResult<RolePermission>>
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
    }
}
