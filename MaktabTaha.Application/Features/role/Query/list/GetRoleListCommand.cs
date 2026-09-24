using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.role.Query.list
{
    public class GetRoleListCommand : IRequest<OperationResult<List<Role>>>
    {
    }
}
