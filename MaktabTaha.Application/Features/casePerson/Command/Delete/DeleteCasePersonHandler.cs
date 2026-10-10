using MaktabTaha.Application.Features.casePerson.Command.Delete;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.casePerson.Command.Delete
{
    public class DeteteCasePersonHandler : IRequestHandler<DeleteCasePersonCommand, OperationResult<bool>>
    {
        private readonly ICasePersonRepository _repository;

        public DeteteCasePersonHandler(ICasePersonRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<bool>> Handle(DeleteCasePersonCommand CasePerson, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();

            var initialCasePerson = await _repository.FirstOrDefault(x => x.Id == CasePerson.Id);
            if (initialCasePerson == null) return operation.Failure("درخواست اولیه وجود ندارد.");

            await _repository.Delete(initialCasePerson);
            return operation.Succedded(true);
        }
    }
}
