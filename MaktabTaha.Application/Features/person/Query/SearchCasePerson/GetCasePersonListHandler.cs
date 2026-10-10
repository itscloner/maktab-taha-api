using AutoMapper;
using MaktabTaha.Application.DTO_s.person.Search;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.person.Query.SearchCasePerson
{
    public class GetCasePersonListHandler : IRequestHandler<GetCasePersonListCommand, OperationResult<List<SearchCasePersonListDTO>>>
    {
        private readonly IPersonRepository _repository;
        private readonly IMapper _mapper;

        public GetCasePersonListHandler(IPersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<SearchCasePersonListDTO>>> Handle(GetCasePersonListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<SearchCasePersonListDTO>>();

            var Persons = await _repository.SearchCasePerson(request.Filters);

            var mappedData = _mapper.Map<List<SearchCasePersonListDTO>>(Persons);
            return operation.Succedded(mappedData);
        }
    }
}
