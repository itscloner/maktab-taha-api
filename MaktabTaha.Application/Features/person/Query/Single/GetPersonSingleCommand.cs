using MaktabTaha.Application.DTO_s.person.Single;
using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.person.Query.Single
{
    public class GetPersonSingleCommand : IRequest<OperationResult<PersonSingleDTO>>
    {
        public int Id { get; set; }
    }
}
