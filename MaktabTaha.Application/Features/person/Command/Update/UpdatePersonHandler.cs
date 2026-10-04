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

namespace MaktabTaha.Application.Features.person.Command.Update
{
    public class UpdatePersonHandler : IRequestHandler<UpdatePersonCommand, OperationResult<Person>>
    {
        private readonly IPersonRepository _repository;
        private readonly IMapper _mapper;

        public UpdatePersonHandler(IPersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<Person>> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<Person>();

            var person = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (person == null) return operation.Failure("شخص یافت نشد");

            _mapper.Map(request, person);
            await _repository.Update(person);

            return operation.Succedded(person);
        }
    }
}
