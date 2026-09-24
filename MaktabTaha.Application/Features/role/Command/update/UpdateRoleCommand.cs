using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.role.Command.update
{
    public class UpdateRoleCommand : IRequest<OperationResult<bool>>
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public bool IsSystemAdmin { get; set; }

    }
}
