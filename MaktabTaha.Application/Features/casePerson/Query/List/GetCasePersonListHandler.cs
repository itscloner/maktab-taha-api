using AutoMapper;
using MaktabTaha.Application.DTO_s.casePerson.List;
using MaktabTaha.Application.Features.casePerson.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;
using System.Runtime.CompilerServices;

namespace MaktabTaha.Application.Features.casePerson.Query.List
{
    public class GetCasePersonListHandler : IRequestHandler<GetCasePersonListCommand, OperationResult<List<CasePersonListDTO>>>
    {
        private readonly ICasePersonRepository _respository;
        private readonly IMapper _mapper;

        public GetCasePersonListHandler(ICasePersonRepository respository, IMapper mapper)
        {
            _respository = respository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<CasePersonListDTO>>> Handle(GetCasePersonListCommand CasePerson, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<CasePersonListDTO>>();
            var CasePersons = await _respository.List();
            var mappedData = _mapper.Map<List<CasePersonListDTO>>(CasePersons);
            return operation.Succedded(mappedData);
        }
    }
}
