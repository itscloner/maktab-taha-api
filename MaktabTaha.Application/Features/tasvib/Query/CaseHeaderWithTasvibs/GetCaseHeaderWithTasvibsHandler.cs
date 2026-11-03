using MaktabTaha.Application.DTO_s.tasvib.CaseHeaderWithTasvibs;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using Microsoft.IdentityModel.Tokens.Experimental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.tasvib.Query.CaseHeaderWithTasvibs
{
    public class GetCaseHeaderWithTasvibsHandler : IRequestHandler<GetCaseHeaderWithTasvibsCommand, OperationResult<CaseHeaderWithTasvibsDTO>>
    {
        // فرم نمایش تصویب : اطلاعات هدر فرم و اطلاعات تصویب های انجام شده

        private readonly ICaseRepository _repository;

        public GetCaseHeaderWithTasvibsHandler(ICaseRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<CaseHeaderWithTasvibsDTO>> Handle(GetCaseHeaderWithTasvibsCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<CaseHeaderWithTasvibsDTO>();

            var caseHeaderWithTasvibs = await _repository.GetCaseHeaderWithTasvibs(request.CaseNumber);
            if (caseHeaderWithTasvibs == null) return operation.Failure("پرونده یافت نشد");

            return operation.Succedded(caseHeaderWithTasvibs);
        }
    }
}
