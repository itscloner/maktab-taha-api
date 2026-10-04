using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.person.Command.Create
{
    public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, OperationResult<Person>>
    {
        private readonly IPersonRepository _repository;
        private readonly IMapper _mapper;

        public CreatePersonHandler(IPersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<Person>> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<Person>();

            var mappedData = _mapper.Map<Person>(request);
            await _repository.Create(mappedData);

            return operation.Succedded(mappedData);
        }
    }
}
