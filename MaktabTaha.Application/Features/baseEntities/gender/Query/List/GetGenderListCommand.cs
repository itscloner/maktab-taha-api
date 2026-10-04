using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.gender.Query.List
{
    public class GetGenderListCommand : IRequest<OperationResult<List<Gender>>>
    {
    }
}
