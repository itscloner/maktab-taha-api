using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.permission.Command.Create
{
    public class CreatePermissionCommand : IRequest<OperationResult<Permission>>
    {
        public string Title { get; set; }
        public string Key { get; set; }
        public string? Path { get; set; }
        public string? Icon { get; set; }
        public int? ParentId { get; set; }
        public int SortOrder { get; set; }

    }
}
