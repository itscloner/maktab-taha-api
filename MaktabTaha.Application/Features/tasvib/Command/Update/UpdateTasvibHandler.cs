using AutoMapper;
using MaktabTaha.Application.DTO_s.tasvib.Update;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.tasvib.Command.Update
{
    public class UpdateTasvibHandler : IRequestHandler<UpdateTasvibCommand, OperationResult<UpdateTasvibDTO>>
    {
        private readonly ITasvibRepository _repository;
        private readonly IMapper _mapper;

        public UpdateTasvibHandler(ITasvibRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<UpdateTasvibDTO>> Handle(UpdateTasvibCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<UpdateTasvibDTO>();
            var tasvib = await _repository.FirstOrDefaultWith(request.CaseNumber);
            
            if (tasvib != null) return operation.Failure("فرم تصویب یافت نشد.");
            
            if (tasvib.Case.CaseStageId != 4) return operation.Failure("پرونده در مرحله تصویب نمی‌باشد");

            if (tasvib.ManagerTasvibStatusId == 2) return operation.Failure("این تصویب مورد تایید مدیر واقع شده است و امکان ویرایش ندارد.");

            _mapper.Map(request, tasvib);
            await _repository.Update(tasvib);

            var mappedData = _mapper.Map<UpdateTasvibDTO>(tasvib);
            return operation.Succedded(mappedData);
        }
    }
}
