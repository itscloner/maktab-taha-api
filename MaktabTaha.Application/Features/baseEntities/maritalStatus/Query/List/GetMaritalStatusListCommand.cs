using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.maritalStatus.Query.List
{
    public class GetMaritalStatusListCommand : IRequest<OperationResult<List<MaritalStatus>>>
    {
    }
}
