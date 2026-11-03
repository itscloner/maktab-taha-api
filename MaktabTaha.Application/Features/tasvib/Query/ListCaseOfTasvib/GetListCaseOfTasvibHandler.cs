using MaktabTaha.Application.DTO_s.tasvib.ListCaseOfTasvib;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.tasvib.Query.ListCaseOfTasvib
{
    public class GetListCaseOfTasvibHandler : IRequestHandler<GetListCaseOfTasvibCommand, OperationResult<List<ListCaseOfTasvibDTO>>>
    {
        // لیست پرونده های تصویب

        private readonly ITasvibRepository _repository;

        public GetListCaseOfTasvibHandler(ITasvibRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<ListCaseOfTasvibDTO>>> Handle(GetListCaseOfTasvibCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<ListCaseOfTasvibDTO>>();

            var data = await _repository.SearchCaseOfTasvibList(request.Filters);
            if (data == null) return operation.Failure("پرونده های تصویب یافت نشدند");

            return operation.Succedded(data);
        }
    }
}
