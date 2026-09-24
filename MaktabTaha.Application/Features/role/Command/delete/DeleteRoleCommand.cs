using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.role.Command.delete
{
    public class DeleteRoleCommand : IRequest<OperationResult<bool>>
    {
        public int Id { get; set; }
    }
}
