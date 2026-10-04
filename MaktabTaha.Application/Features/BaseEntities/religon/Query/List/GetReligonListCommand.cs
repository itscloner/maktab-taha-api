using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.religon.Query.List;

public class GetReligonListCommand : IRequest<OperationResult<List<Religon>>>
{
}
