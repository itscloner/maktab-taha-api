using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.role_permission.Query.List
{
    public class GetRolePermissionListCommand : IRequest<OperationResult<List<RolePermission>>>
    {
    }
}
