using AutoMapper;
using MaktabTaha.Application.DTO_s.tasvib.Single;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.tasvib.Query.Single
{
    public class GetTavibSingleHandler : IRequestHandler<GetTavibSingleCommand, OperationResult<SingleTasvibDTO>>
    {
        private readonly ITasvibRepository _repository;
        private readonly IMapper _mapper;

        public GetTavibSingleHandler(ITasvibRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<SingleTasvibDTO>> Handle(GetTavibSingleCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<SingleTasvibDTO>();

            var tasvib = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (tasvib != null) return operation.Failure("فرم تصویب موجود نمیباشد");

            var mappedData = _mapper.Map<SingleTasvibDTO>(tasvib);
            return operation.Succedded(mappedData);
        }
    }
}
