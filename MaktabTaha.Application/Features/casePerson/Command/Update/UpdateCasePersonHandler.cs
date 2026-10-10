using AutoMapper;
using MaktabTaha.Application.Features.casePerson.Command.Update;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.casePerson.Command.Update
{
    public class UpdateCasePersonHandler : IRequestHandler<UpdateCasePersonCommand, OperationResult<CasePerson>>
    {
        private readonly ICasePersonRepository _repository;
        private readonly IMapper _mapper;

        public UpdateCasePersonHandler(ICasePersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<CasePerson>> Handle(UpdateCasePersonCommand CasePerson, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<CasePerson>();

            var initialCasePerson = await _repository.FirstOrDefault(x => x.Id == CasePerson.Id);
            if (initialCasePerson == null) return operation.Failure("درخواست اولیه موجود نمیباشد");
            _mapper.Map(CasePerson, initialCasePerson);
            await _repository.Update(initialCasePerson);
            return operation.Succedded(initialCasePerson);
        }
    }
}
