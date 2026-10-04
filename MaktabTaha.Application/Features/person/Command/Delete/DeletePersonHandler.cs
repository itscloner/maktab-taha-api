using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.person.Command.Delete
{
    public class DeletePersonHandler : IRequestHandler<DeletePersonCommand, OperationResult<bool>>
    {
        private readonly IPersonRepository _repository;

        public DeletePersonHandler(IPersonRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<bool>> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();

            var person = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (person == null) return operation.Failure("شخص یافت نشد");

            await _repository.Delete(person);
            return operation.Succedded(true);
        }
    }
}
