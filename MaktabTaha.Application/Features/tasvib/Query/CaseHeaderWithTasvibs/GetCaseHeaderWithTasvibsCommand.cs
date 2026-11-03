using MaktabTaha.Application.DTO_s.tasvib.CaseHeaderWithTasvibs;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.tasvib.Query.CaseHeaderWithTasvibs
{
    public class GetCaseHeaderWithTasvibsCommand : IRequest<OperationResult<CaseHeaderWithTasvibsDTO>>
    {
        // فرم نمایش تصویب : اطلاعات هدر فرم و اطلاعات تصویب های انجام شده
        public string CaseNumber { get; set; }
    }
}
