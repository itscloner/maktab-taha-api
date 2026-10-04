using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.nationality.Query.List
{
    public class GetNationalityListCommand : IRequest<OperationResult<List<Nationality>>>
    {
    }
}
