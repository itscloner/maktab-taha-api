using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.role.Command.create
{
    public class CreateRoleCommand : IRequest<OperationResult<int>>
    {
        public string Title { get; set; } = null!;
        public bool IsSystemAdmin { get; set; }

    }
}
