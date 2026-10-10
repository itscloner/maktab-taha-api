using AutoMapper;
using MaktabTaha.Application.DTO_s.casePerson.List;
using MaktabTaha.Application.DTO_s.casePerson.Single;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.casePerson.Query.Single
{
    public class GetSingleCasePersonHandler : IRequestHandler<GetSingleCasePersonCommand, OperationResult<CasePersonSingleDTO>>
    {
        private readonly ICasePersonRepository _repository;
        private readonly IMapper _mapper;

        public GetSingleCasePersonHandler(ICasePersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        async Task<OperationResult<CasePersonSingleDTO>> IRequestHandler<GetSingleCasePersonCommand, OperationResult<CasePersonSingleDTO>>.Handle(GetSingleCasePersonCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<CasePersonSingleDTO>();
            var casePerson = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (casePerson == null) return operation.Failure("یافت نشد");

            var mappedData = _mapper.Map<CasePersonSingleDTO>(casePerson);
            return operation.Succedded(mappedData);
        }
    }
}
