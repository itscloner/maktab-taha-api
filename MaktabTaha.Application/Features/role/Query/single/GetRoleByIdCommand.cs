using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.role.Query.single
{
    public class GetRoleByIdCommand : IRequest<OperationResult<Role>>
    {
        public int Id { get; set; }
    }
}
