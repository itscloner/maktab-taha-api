using AutoMapper;
using MaktabTaha.Application.DTO_s.person.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.person.Query.List
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListCommand, OperationResult<List<PersonListDTO>>>
    {
        private readonly IPersonRepository _repository;
        private readonly IMapper _mapper;

        public GetPersonListHandler(IPersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<PersonListDTO>>> Handle(GetPersonListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<PersonListDTO>>();

            var persons = await _repository.List();

            var mappedData = _mapper.Map<List<PersonListDTO>>(persons);
            return operation.Succedded(mappedData);
        }
    }
}
