using AutoMapper.Internal.Mappers;
using MaktabTaha.Application.DTO_s.tasvib.TasvibDetails;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.tasvib.Query.TasvibDetails
{
    // اطلاعات جزئیات تصویب
    public class GetTasvibDetailsHandler : IRequestHandler<GetTasvibDetailsCommand, OperationResult<TasvibDetailsDTO>>
    {
        private readonly ITasvibRepository _repository;

        public GetTasvibDetailsHandler(ITasvibRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<TasvibDetailsDTO>> Handle(GetTasvibDetailsCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<TasvibDetailsDTO>();

            var tasvibDetails = await _repository.GetTasvibDetails(request.Id);
            if (tasvibDetails == null) return operation.Failure("فرم تصویب وجود ندارد");

            return operation.Succedded(tasvibDetails);
        }
    }
}
