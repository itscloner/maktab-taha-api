using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.role_permission.Command.Delete
{
    public class DeleteRolePermissionCommand : IRequest<OperationResult<bool>>
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
    }
}
